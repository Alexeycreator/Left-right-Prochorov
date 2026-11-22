namespace Left_right.App;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        cmbx_inputTask = new System.Windows.Forms.ComboBox();
        nud_lambda_min = new System.Windows.Forms.NumericUpDown();
        nud_lambda_max = new System.Windows.Forms.NumericUpDown();
        nud_lambda_delta = new System.Windows.Forms.NumericUpDown();
        nud_sample_thickness = new System.Windows.Forms.NumericUpDown();
        nud_concentration = new System.Windows.Forms.NumericUpDown();
        cmbx_concentration_units = new System.Windows.Forms.ComboBox();
        nud_path_length = new System.Windows.Forms.NumericUpDown();
        nud_molar_mass = new System.Windows.Forms.NumericUpDown();
        rBtn_right_environment = new System.Windows.Forms.RadioButton();
        rBtn_left_environment = new System.Windows.Forms.RadioButton();
        cmbx_model_strip_type = new System.Windows.Forms.ComboBox();
        btn_add_lane = new System.Windows.Forms.Button();
        btn_clear_lane = new System.Windows.Forms.Button();
        btn_remove_lane = new System.Windows.Forms.Button();
        dgv_table_lanes = new System.Windows.Forms.DataGridView();
        grp_task = new System.Windows.Forms.GroupBox();
        label_task = new System.Windows.Forms.Label();
        grp_experiment = new System.Windows.Forms.GroupBox();
        label_molar_mass = new System.Windows.Forms.Label();
        label_path_length = new System.Windows.Forms.Label();
        label_concentration_units = new System.Windows.Forms.Label();
        label_concentration = new System.Windows.Forms.Label();
        label_thickness = new System.Windows.Forms.Label();
        label_lambda_delta = new System.Windows.Forms.Label();
        label_lambda_max = new System.Windows.Forms.Label();
        label_lambda_min = new System.Windows.Forms.Label();
        grp_medium = new System.Windows.Forms.GroupBox();
        label_strip_type = new System.Windows.Forms.Label();
        label_environment = new System.Windows.Forms.Label();
        grp_output = new System.Windows.Forms.GroupBox();
        label_output_units = new System.Windows.Forms.Label();
        cmbx_output_units = new System.Windows.Forms.ComboBox();
        chk_want_png = new System.Windows.Forms.CheckBox();
        chk_want_json = new System.Windows.Forms.CheckBox();
        btn_calculate = new System.Windows.Forms.Button();
        lbl_status = new System.Windows.Forms.Label();
        grp_formulas = new System.Windows.Forms.GroupBox();
        rtb_formulas = new System.Windows.Forms.RichTextBox();
        dgv_preview = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)nud_lambda_min).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nud_lambda_max).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nud_lambda_delta).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nud_sample_thickness).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nud_concentration).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nud_path_length).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nud_molar_mass).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgv_table_lanes).BeginInit();
        grp_task.SuspendLayout();
        grp_experiment.SuspendLayout();
        grp_medium.SuspendLayout();
        grp_output.SuspendLayout();
        grp_formulas.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgv_preview).BeginInit();
        SuspendLayout();
        // 
        // cmbx_inputTask
        // 
        cmbx_inputTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbx_inputTask.FormattingEnabled = true;
        cmbx_inputTask.Location = new System.Drawing.Point(21, 55);
        cmbx_inputTask.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
        cmbx_inputTask.Name = "cmbx_inputTask";
        cmbx_inputTask.Size = new System.Drawing.Size(604, 30);
        cmbx_inputTask.TabIndex = 0;
        // 
        // nud_lambda_min
        // 
        nud_lambda_min.Location = new System.Drawing.Point(21, 60);
        nud_lambda_min.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
        nud_lambda_min.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        nud_lambda_min.Name = "nud_lambda_min";
        nud_lambda_min.Size = new System.Drawing.Size(248, 30);
        nud_lambda_min.TabIndex = 1;
        // 
        // nud_lambda_max
        // 
        nud_lambda_max.Location = new System.Drawing.Point(21, 132);
        nud_lambda_max.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
        nud_lambda_max.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        nud_lambda_max.Name = "nud_lambda_max";
        nud_lambda_max.Size = new System.Drawing.Size(248, 30);
        nud_lambda_max.TabIndex = 2;
        // 
        // nud_lambda_delta
        // 
        nud_lambda_delta.DecimalPlaces = 3;
        nud_lambda_delta.Location = new System.Drawing.Point(21, 204);
        nud_lambda_delta.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
        nud_lambda_delta.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nud_lambda_delta.Minimum = new decimal(new int[] { 1, 0, 0, 196608 });
        nud_lambda_delta.Name = "nud_lambda_delta";
        nud_lambda_delta.Size = new System.Drawing.Size(248, 30);
        nud_lambda_delta.TabIndex = 3;
        nud_lambda_delta.Value = new decimal(new int[] { 1, 0, 0, 196608 });
        // 
        // nud_sample_thickness
        // 
        nud_sample_thickness.DecimalPlaces = 3;
        nud_sample_thickness.Location = new System.Drawing.Point(316, 60);
        nud_sample_thickness.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
        nud_sample_thickness.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        nud_sample_thickness.Name = "nud_sample_thickness";
        nud_sample_thickness.Size = new System.Drawing.Size(248, 30);
        nud_sample_thickness.TabIndex = 4;
        // 
        // nud_concentration
        // 
        nud_concentration.DecimalPlaces = 4;
        nud_concentration.Location = new System.Drawing.Point(316, 132);
        nud_concentration.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
        nud_concentration.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        nud_concentration.Name = "nud_concentration";
        nud_concentration.Size = new System.Drawing.Size(248, 30);
        nud_concentration.TabIndex = 5;
        // 
        // cmbx_concentration_units
        // 
        cmbx_concentration_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbx_concentration_units.FormattingEnabled = true;
        cmbx_concentration_units.Location = new System.Drawing.Point(21, 275);
        cmbx_concentration_units.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
        cmbx_concentration_units.Name = "cmbx_concentration_units";
        cmbx_concentration_units.Size = new System.Drawing.Size(246, 30);
        cmbx_concentration_units.TabIndex = 6;
        // 
        // nud_path_length
        // 
        nud_path_length.DecimalPlaces = 3;
        nud_path_length.Location = new System.Drawing.Point(316, 204);
        nud_path_length.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
        nud_path_length.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        nud_path_length.Name = "nud_path_length";
        nud_path_length.Size = new System.Drawing.Size(248, 30);
        nud_path_length.TabIndex = 7;
        // 
        // nud_molar_mass
        // 
        nud_molar_mass.DecimalPlaces = 3;
        nud_molar_mass.Location = new System.Drawing.Point(316, 275);
        nud_molar_mass.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
        nud_molar_mass.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        nud_molar_mass.Name = "nud_molar_mass";
        nud_molar_mass.Size = new System.Drawing.Size(248, 30);
        nud_molar_mass.TabIndex = 8;
        // 
        // rBtn_right_environment
        // 
        rBtn_right_environment.AutoSize = true;
        rBtn_right_environment.Location = new System.Drawing.Point(21, 60);
        rBtn_right_environment.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
        rBtn_right_environment.Name = "rBtn_right_environment";
        rBtn_right_environment.Size = new System.Drawing.Size(205, 26);
        rBtn_right_environment.TabIndex = 9;
        rBtn_right_environment.TabStop = true;
        rBtn_right_environment.Text = "Правая среда (φ > 0)";
        rBtn_right_environment.UseVisualStyleBackColor = true;
        // 
        // rBtn_left_environment
        // 
        rBtn_left_environment.AutoSize = true;
        rBtn_left_environment.Location = new System.Drawing.Point(21, 99);
        rBtn_left_environment.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
        rBtn_left_environment.Name = "rBtn_left_environment";
        rBtn_left_environment.Size = new System.Drawing.Size(195, 26);
        rBtn_left_environment.TabIndex = 10;
        rBtn_left_environment.TabStop = true;
        rBtn_left_environment.Text = "Левая среда (φ < 0)";
        rBtn_left_environment.UseVisualStyleBackColor = true;
        // 
        // cmbx_model_strip_type
        // 
        cmbx_model_strip_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbx_model_strip_type.FormattingEnabled = true;
        cmbx_model_strip_type.Location = new System.Drawing.Point(21, 170);
        cmbx_model_strip_type.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
        cmbx_model_strip_type.Name = "cmbx_model_strip_type";
        cmbx_model_strip_type.Size = new System.Drawing.Size(384, 30);
        cmbx_model_strip_type.TabIndex = 11;
        // 
        // btn_add_lane
        // 
        btn_add_lane.Location = new System.Drawing.Point(21, 226);
        btn_add_lane.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
        btn_add_lane.Name = "btn_add_lane";
        btn_add_lane.Size = new System.Drawing.Size(172, 38);
        btn_add_lane.TabIndex = 12;
        btn_add_lane.Text = "Добавить";
        btn_add_lane.UseVisualStyleBackColor = true;
        // 
        // btn_clear_lane
        // 
        btn_clear_lane.Location = new System.Drawing.Point(213, 226);
        btn_clear_lane.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
        btn_clear_lane.Name = "btn_clear_lane";
        btn_clear_lane.Size = new System.Drawing.Size(172, 38);
        btn_clear_lane.TabIndex = 13;
        btn_clear_lane.Text = "Очистить";
        btn_clear_lane.UseVisualStyleBackColor = true;
        // 
        // btn_remove_lane
        // 
        btn_remove_lane.Location = new System.Drawing.Point(406, 226);
        btn_remove_lane.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
        btn_remove_lane.Name = "btn_remove_lane";
        btn_remove_lane.Size = new System.Drawing.Size(172, 38);
        btn_remove_lane.TabIndex = 14;
        btn_remove_lane.Text = "Удалить";
        btn_remove_lane.UseVisualStyleBackColor = true;
        // 
        // dgv_table_lanes
        // 
        dgv_table_lanes.AllowUserToAddRows = false;
        dgv_table_lanes.AllowUserToDeleteRows = false;
        dgv_table_lanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_table_lanes.Location = new System.Drawing.Point(21, 286);
        dgv_table_lanes.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
        dgv_table_lanes.Name = "dgv_table_lanes";
        dgv_table_lanes.RowHeadersWidth = 51;
        dgv_table_lanes.Size = new System.Drawing.Size(557, 220);
        dgv_table_lanes.TabIndex = 15;
        // 
        // grp_task
        // 
        grp_task.Controls.Add(label_task);
        grp_task.Controls.Add(cmbx_inputTask);
        grp_task.Location = new System.Drawing.Point(16, 13);
        grp_task.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        grp_task.Name = "grp_task";
        grp_task.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        grp_task.Size = new System.Drawing.Size(646, 104);
        grp_task.TabIndex = 16;
        grp_task.TabStop = false;
        grp_task.Text = "1. Тип задачи";
        // 
        // label_task
        // 
        label_task.AutoSize = true;
        label_task.Location = new System.Drawing.Point(21, 28);
        label_task.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label_task.Name = "label_task";
        label_task.Size = new System.Drawing.Size(176, 22);
        label_task.TabIndex = 17;
        label_task.Text = "Что рассчитываем?";
        // 
        // grp_experiment
        // 
        grp_experiment.Controls.Add(label_molar_mass);
        grp_experiment.Controls.Add(label_path_length);
        grp_experiment.Controls.Add(label_concentration_units);
        grp_experiment.Controls.Add(label_concentration);
        grp_experiment.Controls.Add(label_thickness);
        grp_experiment.Controls.Add(label_lambda_delta);
        grp_experiment.Controls.Add(label_lambda_max);
        grp_experiment.Controls.Add(label_lambda_min);
        grp_experiment.Controls.Add(nud_molar_mass);
        grp_experiment.Controls.Add(nud_path_length);
        grp_experiment.Controls.Add(cmbx_concentration_units);
        grp_experiment.Controls.Add(nud_concentration);
        grp_experiment.Controls.Add(nud_sample_thickness);
        grp_experiment.Controls.Add(nud_lambda_delta);
        grp_experiment.Controls.Add(nud_lambda_max);
        grp_experiment.Controls.Add(nud_lambda_min);
        grp_experiment.Location = new System.Drawing.Point(16, 132);
        grp_experiment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        grp_experiment.Name = "grp_experiment";
        grp_experiment.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        grp_experiment.Size = new System.Drawing.Size(646, 341);
        grp_experiment.TabIndex = 17;
        grp_experiment.TabStop = false;
        grp_experiment.Text = "2. Параметры эксперимента";
        // 
        // label_molar_mass
        // 
        label_molar_mass.AutoSize = true;
        label_molar_mass.Location = new System.Drawing.Point(316, 248);
        label_molar_mass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label_molar_mass.Name = "label_molar_mass";
        label_molar_mass.Size = new System.Drawing.Size(131, 22);
        label_molar_mass.TabIndex = 25;
        label_molar_mass.Text = "Моляр. масса:";
        // 
        // label_path_length
        // 
        label_path_length.AutoSize = true;
        label_path_length.Location = new System.Drawing.Point(316, 176);
        label_path_length.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label_path_length.Name = "label_path_length";
        label_path_length.Size = new System.Drawing.Size(127, 22);
        label_path_length.TabIndex = 24;
        label_path_length.Text = "Путь (дм/см):";
        // 
        // label_concentration_units
        // 
        label_concentration_units.AutoSize = true;
        label_concentration_units.Location = new System.Drawing.Point(21, 248);
        label_concentration_units.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label_concentration_units.Name = "label_concentration_units";
        label_concentration_units.Size = new System.Drawing.Size(146, 22);
        label_concentration_units.TabIndex = 23;
        label_concentration_units.Text = "Единицы конц.:";
        // 
        // label_concentration
        // 
        label_concentration.AutoSize = true;
        label_concentration.Location = new System.Drawing.Point(316, 104);
        label_concentration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label_concentration.Name = "label_concentration";
        label_concentration.Size = new System.Drawing.Size(139, 22);
        label_concentration.TabIndex = 22;
        label_concentration.Text = "Концентрация:";
        // 
        // label_thickness
        // 
        label_thickness.AutoSize = true;
        label_thickness.Location = new System.Drawing.Point(316, 33);
        label_thickness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label_thickness.Name = "label_thickness";
        label_thickness.Size = new System.Drawing.Size(136, 22);
        label_thickness.TabIndex = 21;
        label_thickness.Text = "Толщина (мм):";
        // 
        // label_lambda_delta
        // 
        label_lambda_delta.AutoSize = true;
        label_lambda_delta.Location = new System.Drawing.Point(21, 176);
        label_lambda_delta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label_lambda_delta.Name = "label_lambda_delta";
        label_lambda_delta.Size = new System.Drawing.Size(82, 22);
        label_lambda_delta.TabIndex = 20;
        label_lambda_delta.Text = "Δλ (нм):";
        // 
        // label_lambda_max
        // 
        label_lambda_max.AutoSize = true;
        label_lambda_max.Location = new System.Drawing.Point(21, 104);
        label_lambda_max.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label_lambda_max.Name = "label_lambda_max";
        label_lambda_max.Size = new System.Drawing.Size(111, 22);
        label_lambda_max.TabIndex = 19;
        label_lambda_max.Text = "λ_max (нм):";
        // 
        // label_lambda_min
        // 
        label_lambda_min.AutoSize = true;
        label_lambda_min.Location = new System.Drawing.Point(21, 33);
        label_lambda_min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label_lambda_min.Name = "label_lambda_min";
        label_lambda_min.Size = new System.Drawing.Size(108, 22);
        label_lambda_min.TabIndex = 18;
        label_lambda_min.Text = "λ_min (нм):";
        // 
        // grp_medium
        // 
        grp_medium.Controls.Add(label_strip_type);
        grp_medium.Controls.Add(label_environment);
        grp_medium.Controls.Add(dgv_table_lanes);
        grp_medium.Controls.Add(btn_remove_lane);
        grp_medium.Controls.Add(btn_clear_lane);
        grp_medium.Controls.Add(btn_add_lane);
        grp_medium.Controls.Add(cmbx_model_strip_type);
        grp_medium.Controls.Add(rBtn_left_environment);
        grp_medium.Controls.Add(rBtn_right_environment);
        grp_medium.Location = new System.Drawing.Point(688, 13);
        grp_medium.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        grp_medium.Name = "grp_medium";
        grp_medium.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        grp_medium.Size = new System.Drawing.Size(605, 528);
        grp_medium.TabIndex = 18;
        grp_medium.TabStop = false;
        grp_medium.Text = "3. Модель среды";
        // 
        // label_strip_type
        // 
        label_strip_type.AutoSize = true;
        label_strip_type.Location = new System.Drawing.Point(21, 143);
        label_strip_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label_strip_type.Name = "label_strip_type";
        label_strip_type.Size = new System.Drawing.Size(105, 22);
        label_strip_type.TabIndex = 27;
        label_strip_type.Text = "Тип полос:";
        // 
        // label_environment
        // 
        label_environment.AutoSize = true;
        label_environment.Location = new System.Drawing.Point(21, 28);
        label_environment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label_environment.Name = "label_environment";
        label_environment.Size = new System.Drawing.Size(106, 22);
        label_environment.TabIndex = 26;
        label_environment.Text = "Тип среды:";
        // 
        // grp_output
        // 
        grp_output.Controls.Add(label_output_units);
        grp_output.Controls.Add(cmbx_output_units);
        grp_output.Controls.Add(chk_want_png);
        grp_output.Controls.Add(chk_want_json);
        grp_output.Location = new System.Drawing.Point(16, 490);
        grp_output.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        grp_output.Name = "grp_output";
        grp_output.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        grp_output.Size = new System.Drawing.Size(646, 143);
        grp_output.TabIndex = 19;
        grp_output.TabStop = false;
        grp_output.Text = "4. Выходные данные";
        // 
        // label_output_units
        // 
        label_output_units.AutoSize = true;
        label_output_units.Location = new System.Drawing.Point(21, 94);
        label_output_units.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label_output_units.Name = "label_output_units";
        label_output_units.Size = new System.Drawing.Size(159, 22);
        label_output_units.TabIndex = 23;
        label_output_units.Text = "Единицы вывода:";
        // 
        // cmbx_output_units
        // 
        cmbx_output_units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cmbx_output_units.FormattingEnabled = true;
        cmbx_output_units.Items.AddRange(new object[] { "град", "мград", "ΔA", "Δε" });
        cmbx_output_units.Location = new System.Drawing.Point(316, 88);
        cmbx_output_units.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        cmbx_output_units.Name = "cmbx_output_units";
        cmbx_output_units.Size = new System.Drawing.Size(246, 30);
        cmbx_output_units.TabIndex = 22;
        // 
        // chk_want_png
        // 
        chk_want_png.AutoSize = true;
        chk_want_png.Checked = true;
        chk_want_png.CheckState = System.Windows.Forms.CheckState.Checked;
        chk_want_png.Location = new System.Drawing.Point(21, 66);
        chk_want_png.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        chk_want_png.Name = "chk_want_png";
        chk_want_png.Size = new System.Drawing.Size(247, 26);
        chk_want_png.TabIndex = 21;
        chk_want_png.Text = "Построить график (PNG)";
        chk_want_png.UseVisualStyleBackColor = true;
        // 
        // chk_want_json
        // 
        chk_want_json.AutoSize = true;
        chk_want_json.Checked = true;
        chk_want_json.CheckState = System.Windows.Forms.CheckState.Checked;
        chk_want_json.Location = new System.Drawing.Point(21, 33);
        chk_want_json.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        chk_want_json.Name = "chk_want_json";
        chk_want_json.Size = new System.Drawing.Size(285, 26);
        chk_want_json.TabIndex = 20;
        chk_want_json.Text = "Вернуть массив точек (JSON)";
        chk_want_json.UseVisualStyleBackColor = true;
        // 
        // btn_calculate
        // 
        btn_calculate.BackColor = System.Drawing.Color.LightSteelBlue;
        btn_calculate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
        btn_calculate.Location = new System.Drawing.Point(688, 561);
        btn_calculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        btn_calculate.Name = "btn_calculate";
        btn_calculate.Size = new System.Drawing.Size(605, 55);
        btn_calculate.TabIndex = 24;
        btn_calculate.Text = "Сформировать JSON";
        btn_calculate.UseVisualStyleBackColor = false;
        // 
        // lbl_status
        // 
        lbl_status.AutoSize = true;
        lbl_status.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)204));
        lbl_status.ForeColor = System.Drawing.Color.DarkSlateGray;
        lbl_status.Location = new System.Drawing.Point(688, 627);
        lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        lbl_status.Name = "lbl_status";
        lbl_status.Size = new System.Drawing.Size(73, 22);
        lbl_status.TabIndex = 25;
        lbl_status.Text = "Готово";
        // 
        // grp_formulas
        // 
        grp_formulas.Controls.Add(rtb_formulas);
        grp_formulas.Location = new System.Drawing.Point(1315, 12);
        grp_formulas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        grp_formulas.Name = "grp_formulas";
        grp_formulas.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
        grp_formulas.Size = new System.Drawing.Size(596, 802);
        grp_formulas.TabIndex = 26;
        grp_formulas.TabStop = false;
        grp_formulas.Text = "Справочник формул";
        // 
        // rtb_formulas
        // 
        rtb_formulas.BackColor = System.Drawing.SystemColors.ControlLightLight;
        rtb_formulas.BorderStyle = System.Windows.Forms.BorderStyle.None;
        rtb_formulas.Dock = System.Windows.Forms.DockStyle.Fill;
        rtb_formulas.Font = new System.Drawing.Font("Cambria Math", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        rtb_formulas.Location = new System.Drawing.Point(4, 26);
        rtb_formulas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        rtb_formulas.Name = "rtb_formulas";
        rtb_formulas.ReadOnly = true;
        rtb_formulas.Size = new System.Drawing.Size(588, 773);
        rtb_formulas.TabIndex = 27;
        rtb_formulas.Text = "";
        // 
        // dgv_preview
        // 
        dgv_preview.AllowUserToAddRows = false;
        dgv_preview.AllowUserToDeleteRows = false;
        dgv_preview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_preview.Location = new System.Drawing.Point(16, 671);
        dgv_preview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        dgv_preview.Name = "dgv_preview";
        dgv_preview.ReadOnly = true;
        dgv_preview.RowHeadersWidth = 51;
        dgv_preview.Size = new System.Drawing.Size(1277, 143);
        dgv_preview.TabIndex = 28;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1924, 836);
        Controls.Add(dgv_preview);
        Controls.Add(grp_formulas);
        Controls.Add(lbl_status);
        Controls.Add(btn_calculate);
        Controls.Add(grp_output);
        Controls.Add(grp_medium);
        Controls.Add(grp_experiment);
        Controls.Add(grp_task);
        Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Text = "\"Левые\"-\"Правые\" оптические среды";
        ((System.ComponentModel.ISupportInitialize)nud_lambda_min).EndInit();
        ((System.ComponentModel.ISupportInitialize)nud_lambda_max).EndInit();
        ((System.ComponentModel.ISupportInitialize)nud_lambda_delta).EndInit();
        ((System.ComponentModel.ISupportInitialize)nud_sample_thickness).EndInit();
        ((System.ComponentModel.ISupportInitialize)nud_concentration).EndInit();
        ((System.ComponentModel.ISupportInitialize)nud_path_length).EndInit();
        ((System.ComponentModel.ISupportInitialize)nud_molar_mass).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgv_table_lanes).EndInit();
        grp_task.ResumeLayout(false);
        grp_task.PerformLayout();
        grp_experiment.ResumeLayout(false);
        grp_experiment.PerformLayout();
        grp_medium.ResumeLayout(false);
        grp_medium.PerformLayout();
        grp_output.ResumeLayout(false);
        grp_output.PerformLayout();
        grp_formulas.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgv_preview).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ComboBox cmbx_inputTask;
    private NumericUpDown nud_lambda_min;
    private NumericUpDown nud_lambda_max;
    private NumericUpDown nud_lambda_delta;
    private NumericUpDown nud_sample_thickness;
    private NumericUpDown nud_concentration;
    private ComboBox cmbx_concentration_units;
    private NumericUpDown nud_path_length;
    private NumericUpDown nud_molar_mass;
    private RadioButton rBtn_right_environment;
    private RadioButton rBtn_left_environment;
    private ComboBox cmbx_model_strip_type;
    private Button btn_add_lane;
    private Button btn_clear_lane;
    private Button btn_remove_lane;
    private System.Windows.Forms.DataGridView dgv_table_lanes;
    
    private Label label_task;
    private Label label_lambda_min;
    private Label label_lambda_max;
    private Label label_lambda_delta;
    private Label label_thickness;
    private Label label_concentration;
    private Label label_concentration_units;
    private Label label_path_length;
    private Label label_molar_mass;
    private Label label_environment;
    private Label label_strip_type;
    private Label label_output_units;

    private GroupBox grp_task;
    private GroupBox grp_experiment;
    private GroupBox grp_medium;
    private GroupBox grp_output;
    private System.Windows.Forms.GroupBox grp_formulas;
    private CheckBox chk_want_json;
    private CheckBox chk_want_png;
    private ComboBox cmbx_output_units;
    private Button btn_calculate;
    private Label lbl_status;
    private System.Windows.Forms.RichTextBox rtb_formulas;
    private System.Windows.Forms.DataGridView dgv_preview;
}