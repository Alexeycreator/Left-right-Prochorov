using Left_right.App.Models;

namespace Left_right.App;

public partial class MainForm : Form
{
    private readonly PhysicsCalculator _calculator = new();
    private InputDataModel? _currentInputData;

    public MainForm()
    {
        try
        {
            InitializeComponent();
            SetupComboBoxes();
            SetupLanesGrid();
            SetupPreviewGrid();

            rtb_formulas.Text = AppConfig.FormulasText;

            btn_calculate.Click += Btn_calculate_Click;
            btn_add_lane.Click += Btn_add_lane_Click;
            btn_remove_lane.Click += Btn_remove_lane_Click;
            btn_clear_lane.Click += Btn_clear_lane_Click;

            // Легкое обновление предпросмотра при изменении интерфейса
            nud_lambda_min.ValueChanged += (s, e) => UpdatePreviewLight();
            nud_lambda_max.ValueChanged += (s, e) => UpdatePreviewLight();
            nud_lambda_delta.ValueChanged += (s, e) => UpdatePreviewLight();
            nud_sample_thickness.ValueChanged += (s, e) => UpdatePreviewLight();
            nud_concentration.ValueChanged += (s, e) => UpdatePreviewLight();
            nud_path_length.ValueChanged += (s, e) => UpdatePreviewLight();
            nud_molar_mass.ValueChanged += (s, e) => UpdatePreviewLight();
            cmbx_inputTask.SelectedIndexChanged += (s, e) => UpdatePreviewLight();
            cmbx_concentration_units.SelectedIndexChanged += (s, e) => UpdatePreviewLight();
            cmbx_model_strip_type.SelectedIndexChanged += (s, e) => UpdatePreviewLight();
            cmbx_output_units.SelectedIndexChanged += (s, e) => UpdatePreviewLight();
            rBtn_right_environment.CheckedChanged += (s, e) => UpdatePreviewLight();
            rBtn_left_environment.CheckedChanged += (s, e) => UpdatePreviewLight();
            chk_want_json.CheckedChanged += (s, e) => UpdatePreviewLight();
            chk_want_png.CheckedChanged += (s, e) => UpdatePreviewLight();

            UpdatePreviewLight();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при инициализации формы:\n{ex.Message}",
                "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void SetupComboBoxes()
    {
        cmbx_inputTask.Items.AddRange(new object[]
        {
            "ORD по параметрам модели",
            "CD по параметрам модели",
            "CD → ORD через Крамерса — Кронига"
        });
        cmbx_inputTask.SelectedIndex = 0;

        cmbx_concentration_units.Items.AddRange(new object[] { "г/мл", "моль/л" });
        cmbx_concentration_units.SelectedIndex = 0;

        cmbx_model_strip_type.Items.AddRange(new object[] { "Гауссовы полосы", "Лоренцевы полосы" });
        cmbx_model_strip_type.SelectedIndex = 0;

        if (cmbx_output_units.Items.Count == 0)
            cmbx_output_units.Items.AddRange(new object[] { "град", "мград", "ΔA", "Δε" });
        cmbx_output_units.SelectedIndex = 0;
    }

    private void SetupLanesGrid()
    {
        dgv_table_lanes.Columns.Clear();
        dgv_table_lanes.Columns.Add("col_center", "λ_k (нм)");
        dgv_table_lanes.Columns.Add("col_width", "σ_k / γ_k (нм)");
        dgv_table_lanes.Columns.Add("col_amplitude", "A_k (л·моль⁻¹·см⁻¹)");
        dgv_table_lanes.AllowUserToAddRows = false;
        dgv_table_lanes.AllowUserToDeleteRows = false;
    }

    private void SetupPreviewGrid()
    {
        if (Controls.Find("dgv_preview", true).FirstOrDefault() is DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.Columns.Add("col_param", "Параметр");
            dgv.Columns.Add("col_value", "Значение");
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }

    private void Btn_add_lane_Click(object? sender, EventArgs e)
    {
        try
        {
            dgv_table_lanes.Rows.Add(400, 20, 100);
            UpdatePreviewLight();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Не удалось добавить полосу:\n{ex.Message}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void Btn_remove_lane_Click(object? sender, EventArgs e)
    {
        try
        {
            if (dgv_table_lanes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления.",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow row in dgv_table_lanes.SelectedRows)
            {
                if (!row.IsNewRow) dgv_table_lanes.Rows.Remove(row);
            }

            UpdatePreviewLight();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Не удалось удалить полосу:\n{ex.Message}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void Btn_clear_lane_Click(object? sender, EventArgs e)
    {
        try
        {
            dgv_table_lanes.Rows.Clear();
            UpdatePreviewLight();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Не удалось очистить таблицу:\n{ex.Message}",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Только собирает данные и показывает их. Без вычислений.
    /// </summary>
    private void UpdatePreviewLight()
    {
        try
        {
            _currentInputData = CollectInputData();

            if (Controls.Find("dgv_preview", true).FirstOrDefault() is not DataGridView dgv)
                return;

            dgv.Rows.Clear();

            dgv.Rows.Add("Задача", GetTaskName(_currentInputData.Task));
            dgv.Rows.Add("λ_min / λ_max (нм)",
                $"{_currentInputData.Experiment.WavelengthMin} / {_currentInputData.Experiment.WavelengthMax}");
            dgv.Rows.Add("Шаг Δλ (нм)", _currentInputData.Experiment.WavelengthStep);
            dgv.Rows.Add("Толщина (мм)", _currentInputData.Experiment.ThicknessMm);
            dgv.Rows.Add("Концентрация",
                $"{_currentInputData.Experiment.Concentration} {_currentInputData.Experiment.ConcentrationUnits}");
            dgv.Rows.Add("Длина пути", _currentInputData.Experiment.PathLength);
            dgv.Rows.Add("Молярная масса", _currentInputData.Experiment.MolarMass);
            dgv.Rows.Add("Тип среды", _currentInputData.MediumModel.Sign > 0 ? "Правая" : "Левая");
            dgv.Rows.Add("Тип полос",
                _currentInputData.MediumModel.ModelType == "gaussian_bands" ? "Гауссовы" : "Лоренцевы");
            dgv.Rows.Add("Кол-во полос", _currentInputData.MediumModel.Bands.Count);

            lbl_status.Text = "Данные введены. Нажмите «Сформировать JSON» для расчета.";
        }
        catch (Exception ex)
        {
            lbl_status.Text = $"Ошибка предпросмотра: {ex.Message}";
        }
    }

    private string GetTaskName(string task) => task switch
    {
        "ord_from_params" => "ORD по параметрам модели",
        "cd_from_params" => "CD по параметрам модели",
        "cd_to_ord_kramers_kronig" => "CD → ORD через Крамерса — Кронига",
        _ => "Неизвестно"
    };

    private void Btn_calculate_Click(object? sender, EventArgs e)
    {
        int bandCount = dgv_table_lanes.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow);

        bool isValid = DataValidator.ValidateAll(
            cmbx_inputTask.SelectedIndex,
            bandCount,
            nud_lambda_min.Value,
            nud_lambda_max.Value,
            nud_lambda_delta.Value,
            nud_sample_thickness.Value,
            nud_concentration.Value,
            nud_path_length.Value,
            nud_molar_mass.Value,
            rBtn_right_environment.Checked,
            rBtn_left_environment.Checked,
            cmbx_concentration_units.SelectedIndex,
            cmbx_model_strip_type.SelectedIndex,
            cmbx_output_units.SelectedIndex,
            chk_want_json.Checked,
            chk_want_png.Checked,
            out string error);

        if (!isValid)
        {
            MessageBox.Show(error, "Ошибка валидации",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            // Блокируем кнопку и меняем статус
            btn_calculate.Enabled = false;
            lbl_status.Text = "Идет расчет спектров... Пожалуйста, подождите.";
            Application.DoEvents(); // Принудительное обновление UI

            _currentInputData = CollectInputData();

            // ВЫЧИСЛЯЕМ ТОЧКИ
            _currentInputData.Results = _calculator.CalculateFullSpectrum(_currentInputData);

            string path = JsonService.SaveInput(_currentInputData, AppConfig.ExchangeFolderPath);

            lbl_status.Text = $"JSON сохранён: {Path.GetFileName(path)}";
            MessageBox.Show(
                $"Файл input.json успешно сформирован (включая {_currentInputData.Results.Wavelength.Count} точек для графиков):\n{path}",
                "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при формировании JSON:\n{ex.Message}",
                "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            lbl_status.Text = "Ошибка формирования JSON";
        }
        finally
        {
            // Включаем кнопку обратно
            btn_calculate.Enabled = true;
        }
    }

    private InputDataModel CollectInputData()
    {
        string task = cmbx_inputTask.SelectedIndex switch
        {
            0 => "ord_from_params",
            1 => "cd_from_params",
            2 => "cd_to_ord_kramers_kronig",
            _ => "unknown"
        };

        int sign = rBtn_right_environment.Checked ? 1 : -1;

        string modelType = cmbx_model_strip_type.SelectedIndex == 0
            ? "gaussian_bands"
            : "lorentzian_bands";

        var bands = new List<BandData>();
        foreach (DataGridViewRow row in dgv_table_lanes.Rows)
        {
            if (row.IsNewRow) continue;

            try
            {
                bands.Add(new BandData
                {
                    Center = Convert.ToDecimal(row.Cells[0].Value ?? 0),
                    Width = Convert.ToDecimal(row.Cells[1].Value ?? 0),
                    Amplitude = Convert.ToDecimal(row.Cells[2].Value ?? 0)
                });
            }
            catch (FormatException ex)
            {
                throw new FormatException(
                    $"Строка {row.Index + 1}: некорректное числовое значение в таблице полос.", ex);
            }
            catch (InvalidCastException ex)
            {
                throw new InvalidCastException(
                    $"Строка {row.Index + 1}: пустая ячейка в таблице полос.", ex);
            }
        }

        return new InputDataModel
        {
            Task = task,
            Experiment = new ExperimentData
            {
                WavelengthMin = nud_lambda_min.Value,
                WavelengthMax = nud_lambda_max.Value,
                WavelengthStep = nud_lambda_delta.Value,
                ThicknessMm = nud_sample_thickness.Value,
                Concentration = nud_concentration.Value,
                ConcentrationUnits = cmbx_concentration_units.SelectedItem?.ToString() ?? "г/мл",
                PathLength = nud_path_length.Value,
                MolarMass = nud_molar_mass.Value
            },
            MediumModel = new MediumModelData
            {
                Sign = sign,
                ModelType = modelType,
                Bands = bands
            },
            Output = new OutputData
            {
                WantJson = chk_want_json.Checked,
                WantPng = chk_want_png.Checked,
                Units = cmbx_output_units.SelectedItem?.ToString() ?? "град"
            }
        };
    }
}