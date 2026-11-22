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
        cmbx_inputTask = new ComboBox();
        nud_lambda_min = new NumericUpDown();
        nud_lambda_max = new NumericUpDown();
        nud_lambda_delta = new NumericUpDown();
        nud_sample_thickness = new NumericUpDown();
        nud_concentration = new NumericUpDown();
        cmbx_concentration_units = new ComboBox();
        nud_path_length = new NumericUpDown();
        nud_molar_mass = new NumericUpDown();
        rBtn_right_environment = new RadioButton();
        rBtn_left_environment = new RadioButton();
        cmbx_model_strip_type = new ComboBox();
        btn_add_lane = new Button();
        btn_clear_lane = new Button();
        btn_remove_lane = new Button();
        dgv_table_lanes = new DataGridView();
        grp_task = new GroupBox();
        label_task = new Label();
        grp_experiment = new GroupBox();
        label_lambda_min = new Label();
        label_lambda_max = new Label();
        label_lambda_delta = new Label();
        label_thickness = new Label();
        label_concentration = new Label();
        label_concentration_units = new Label();
        label_path_length = new Label();
        label_molar_mass = new Label();
        grp_medium = new GroupBox();
        label_environment = new Label();
        label_strip_type = new Label();
        grp_output = new GroupBox();
        chk_want_json = new CheckBox();
        chk_want_png = new CheckBox();
        cmbx_output_units = new ComboBox();
        label_output_units = new Label();
        btn_calculate = new Button();
        lbl_status = new Label();
        grp_formulas = new GroupBox();
        rtb_formulas = new RichTextBox();
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
        SuspendLayout();
        // 
        // cmbx_inputTask
        // 
        cmbx_inputTask.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbx_inputTask.FormattingEnabled = true;
        cmbx_inputTask.Location = new Point(13, 50);
        cmbx_inputTask.Margin = new Padding(4, 3, 4, 3);
        cmbx_inputTask.Name = "cmbx_inputTask";
        cmbx_inputTask.Size = new Size(384, 30);
        cmbx_inputTask.TabIndex = 0;
        // 
        // nud_lambda_min
        // 
        nud_lambda_min.Location = new Point(13, 55);
        nud_lambda_min.Margin = new Padding(4, 3, 4, 3);
        nud_lambda_min.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        nud_lambda_min.Name = "nud_lambda_min";
        nud_lambda_min.Size = new Size(118, 30);
        nud_lambda_min.TabIndex = 1;
        // 
        // nud_lambda_max
        // 
        nud_lambda_max.Location = new Point(13, 120);
        nud_lambda_max.Margin = new Padding(4, 3, 4, 3);
        nud_lambda_max.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        nud_lambda_max.Name = "nud_lambda_max";
        nud_lambda_max.Size = new Size(118, 30);
        nud_lambda_max.TabIndex = 2;
        // 
        // nud_lambda_delta
        // 
        nud_lambda_delta.DecimalPlaces = 3;
        nud_lambda_delta.Location = new Point(13, 185);
        nud_lambda_delta.Margin = new Padding(4, 3, 4, 3);
        nud_lambda_delta.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nud_lambda_delta.Minimum = new decimal(new int[] { 1, 0, 0, 196608 });
        nud_lambda_delta.Name = "nud_lambda_delta";
        nud_lambda_delta.Size = new Size(118, 30);
        nud_lambda_delta.TabIndex = 3;
        nud_lambda_delta.Value = new decimal(new int[] { 1, 0, 0, 196608 });
        // 
        // nud_sample_thickness
        // 
        nud_sample_thickness.DecimalPlaces = 3;
        nud_sample_thickness.Location = new Point(175, 55);
        nud_sample_thickness.Margin = new Padding(4, 3, 4, 3);
        nud_sample_thickness.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        nud_sample_thickness.Name = "nud_sample_thickness";
        nud_sample_thickness.Size = new Size(118, 30);
        nud_sample_thickness.TabIndex = 4;
        // 
        // nud_concentration
        // 
        nud_concentration.DecimalPlaces = 4;
        nud_concentration.Location = new Point(175, 120);
        nud_concentration.Margin = new Padding(4, 3, 4, 3);
        nud_concentration.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        nud_concentration.Name = "nud_concentration";
        nud_concentration.Size = new Size(118, 30);
        nud_concentration.TabIndex = 5;
        // 
        // cmbx_concentration_units
        // 
        cmbx_concentration_units.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbx_concentration_units.FormattingEnabled = true;
        cmbx_concentration_units.Location = new Point(13, 250);
        cmbx_concentration_units.Margin = new Padding(4, 3, 4, 3);
        cmbx_concentration_units.Name = "cmbx_concentration_units";
        cmbx_concentration_units.Size = new Size(118, 30);
        cmbx_concentration_units.TabIndex = 6;
        // 
        // nud_path_length
        // 
        nud_path_length.DecimalPlaces = 3;
        nud_path_length.Location = new Point(175, 185);
        nud_path_length.Margin = new Padding(4, 3, 4, 3);
        nud_path_length.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
        nud_path_length.Name = "nud_path_length";
        nud_path_length.Size = new Size(118, 30);
        nud_path_length.TabIndex = 7;
        // 
        // nud_molar_mass
        // 
        nud_molar_mass.DecimalPlaces = 3;
        nud_molar_mass.Location = new Point(175, 250);
        nud_molar_mass.Margin = new Padding(4, 3, 4, 3);
        nud_molar_mass.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        nud_molar_mass.Name = "nud_molar_mass";
        nud_molar_mass.Size = new Size(118, 30);
        nud_molar_mass.TabIndex = 8;
        // 
        // rBtn_right_environment
        // 
        rBtn_right_environment.AutoSize = true;
        rBtn_right_environment.Location = new Point(13, 50);
        rBtn_right_environment.Margin = new Padding(4, 3, 4, 3);
        rBtn_right_environment.Name = "rBtn_right_environment";
        rBtn_right_environment.Size = new Size(181, 26);
        rBtn_right_environment.TabIndex = 9;
        rBtn_right_environment.TabStop = true;
        rBtn_right_environment.Text = "Правая среда (φ > 0)";
        rBtn_right_environment.UseVisualStyleBackColor = true;
        // 
        // rBtn_left_environment
        // 
        rBtn_left_environment.AutoSize = true;
        rBtn_left_environment.Location = new Point(13, 85);
        rBtn_left_environment.Margin = new Padding(4, 3, 4, 3);
        rBtn_left_environment.Name = "rBtn_left_environment";
        rBtn_left_environment.Size = new Size(180, 26);
        rBtn_left_environment.TabIndex = 10;
        rBtn_left_environment.TabStop = true;
        rBtn_left_environment.Text = "Левая среда (φ < 0)";
        rBtn_left_environment.UseVisualStyleBackColor = true;
        // 
        // cmbx_model_strip_type
        // 
        cmbx_model_strip_type.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbx_model_strip_type.FormattingEnabled = true;
        cmbx_model_strip_type.Location = new Point(13, 155);
        cmbx_model_strip_type.Margin = new Padding(4, 3, 4, 3);
        cmbx_model_strip_type.Name = "cmbx_model_strip_type";
        cmbx_model_strip_type.Size = new Size(218, 30);
        cmbx_model_strip_type.TabIndex = 11;
        // 
        // btn_add_lane
        // 
        btn_add_lane.Location = new Point(13, 205);
        btn_add_lane.Margin = new Padding(4, 3, 4, 3);
        btn_add_lane.Name = "btn_add_lane";
        btn_add_lane.Size = new Size(103, 30);
        btn_add_lane.TabIndex = 12;
        btn_add_lane.Text = "Добавить";
        btn_add_lane.UseVisualStyleBackColor = true;
        // 
        // btn_clear_lane
        // 
        btn_clear_lane.Location = new Point(128, 205);
        btn_clear_lane.Margin = new Padding(4, 3, 4, 3);
        btn_clear_lane.Name = "btn_clear_lane";
        btn_clear_lane.Size = new Size(103, 30);
        btn_clear_lane.TabIndex = 13;
        btn_clear_lane.Text = "Очистить";
        btn_clear_lane.UseVisualStyleBackColor = true;
        // 
        // btn_remove_lane
        // 
        btn_remove_lane.Location = new Point(243, 205);
        btn_remove_lane.Margin = new Padding(4, 3, 4, 3);
        btn_remove_lane.Name = "btn_remove_lane";
        btn_remove_lane.Size = new Size(103, 30);
        btn_remove_lane.TabIndex = 14;
        btn_remove_lane.Text = "Удалить";
        btn_remove_lane.UseVisualStyleBackColor = true;
        // 
        // dgv_table_lanes
        // 
        dgv_table_lanes.AllowUserToAddRows = false;
        dgv_table_lanes.AllowUserToDeleteRows = false;
        dgv_table_lanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_table_lanes.Location = new Point(13, 250);
        dgv_table_lanes.Margin = new Padding(4, 3, 4, 3);
        dgv_table_lanes.Name = "dgv_table_lanes";
        dgv_table_lanes.RowHeadersWidth = 51;
        dgv_table_lanes.Size = new Size(333, 160);
        dgv_table_lanes.TabIndex = 15;
        // 
        // grp_task
        // 
        grp_task.Controls.Add(label_task);
        grp_task.Controls.Add(cmbx_inputTask);
        grp_task.Location = new Point(12, 12);
        grp_task.Name = "grp_task";
        grp_task.Size = new Size(410, 100);
        grp_task.TabIndex = 16;
        grp_task.TabStop = false;
        grp_task.Text = "1. Тип задачи";
        // 
        // label_task
        // 
        label_task.AutoSize = true;
        label_task.Location = new Point(13, 26);
        label_task.Name = "label_task";
        label_task.Size = new Size(147, 22);
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
        grp_experiment.Location = new Point(12, 125);
        grp_experiment.Name = "grp_experiment";
        grp_experiment.Size = new Size(410, 300);
        grp_experiment.TabIndex = 17;
        grp_experiment.TabStop = false;
        grp_experiment.Text = "2. Параметры эксперимента";
        // 
        // label_lambda_min
        // 
        label_lambda_min.AutoSize = true;
        label_lambda_min.Location = new Point(13, 30);
        label_lambda_min.Name = "label_lambda_min";
        label_lambda_min.Size = new Size(95, 22);
        label_lambda_min.TabIndex = 18;
        label_lambda_min.Text = "λ_min (нм):";
        // 
        // label_lambda_max
        // 
        label_lambda_max.AutoSize = true;
        label_lambda_max.Location = new Point(13, 95);
        label_lambda_max.Name = "label_lambda_max";
        label_lambda_max.Size = new Size(98, 22);
        label_lambda_max.TabIndex = 19;
        label_lambda_max.Text = "λ_max (нм):";
        // 
        // label_lambda_delta
        // 
        label_lambda_delta.AutoSize = true;
        label_lambda_delta.Location = new Point(13, 160);
        label_lambda_delta.Name = "label_lambda_delta";
        label_lambda_delta.Size = new Size(71, 22);
        label_lambda_delta.TabIndex = 20;
        label_lambda_delta.Text = "Δλ (нм):";
        // 
        // label_thickness
        // 
        label_thickness.AutoSize = true;
        label_thickness.Location = new Point(175, 30);
        label_thickness.Name = "label_thickness";
        label_thickness.Size = new Size(114, 22);
        label_thickness.TabIndex = 21;
        label_thickness.Text = "Толщина (мм):";
        // 
        // label_concentration
        // 
        label_concentration.AutoSize = true;
        label_concentration.Location = new Point(175, 95);
        label_concentration.Name = "label_concentration";
        label_concentration.Size = new Size(138, 22);
        label_concentration.TabIndex = 22;
        label_concentration.Text = "Концентрация:";
        // 
        // label_concentration_units
        // 
        label_concentration_units.AutoSize = true;
        label_concentration_units.Location = new Point(13, 225);
        label_concentration_units.Name = "label_concentration_units";
        label_concentration_units.Size = new Size(176, 22);
        label_concentration_units.TabIndex = 23;
        label_concentration_units.Text = "Единицы конц.:";
        // 
        // label_path_length
        // 
        label_path_length.AutoSize = true;
        label_path_length.Location = new Point(175, 160);
        label_path_length.Name = "label_path_length";
        label_path_length.Size = new Size(122, 22);
        label_path_length.TabIndex = 24;
        label_path_length.Text = "Путь (дм/см):";
        // 
        // label_molar_mass
        // 
        label_molar_mass.AutoSize = true;
        label_molar_mass.Location = new Point(175, 225);
        label_molar_mass.Name = "label_molar_mass";
        label_molar_mass.Size = new Size(105, 22);
        label_molar_mass.TabIndex = 25;
        label_molar_mass.Text = "Моляр. масса:";
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
        grp_medium.Location = new Point(435, 12);
        grp_medium.Name = "grp_medium";
        grp_medium.Size = new Size(360, 420);
        grp_medium.TabIndex = 18;
        grp_medium.TabStop = false;
        grp_medium.Text = "3. Модель среды";
        // 
        // label_environment
        // 
        label_environment.AutoSize = true;
        label_environment.Location = new Point(13, 26);
        label_environment.Name = "label_environment";
        label_environment.Size = new Size(94, 22);
        label_environment.TabIndex = 26;
        label_environment.Text = "Тип среды:";
        // 
        // label_strip_type
        // 
        label_strip_type.AutoSize = true;
        label_strip_type.Location = new Point(13, 130);
        label_strip_type.Name = "label_strip_type";
        label_strip_type.Size = new Size(114, 22);
        label_strip_type.TabIndex = 27;
        label_strip_type.Text = "Тип полос:";
        // 
        // grp_output
        // 
        grp_output.Controls.Add(label_output_units);
        grp_output.Controls.Add(cmbx_output_units);
        grp_output.Controls.Add(chk_want_png);
        grp_output.Controls.Add(chk_want_json);
        grp_output.Location = new Point(12, 435);
        grp_output.Name = "grp_output";
        grp_output.Size = new Size(410, 120);
        grp_output.TabIndex = 19;
        grp_output.TabStop = false;
        grp_output.Text = "4. Выходные данные";
        // 
        // chk_want_json
        // 
        chk_want_json.AutoSize = true;
        chk_want_json.Checked = true;
        chk_want_json.CheckState = CheckState.Checked;
        chk_want_json.Location = new Point(13, 30);
        chk_want_json.Name = "chk_want_json";
        chk_want_json.Size = new Size(250, 26);
        chk_want_json.TabIndex = 20;
        chk_want_json.Text = "Вернуть массив точек (JSON)";
        chk_want_json.UseVisualStyleBackColor = true;
        // 
        // chk_want_png
        // 
        chk_want_png.AutoSize = true;
        chk_want_png.Checked = true;
        chk_want_png.CheckState = CheckState.Checked;
        chk_want_png.Location = new Point(13, 60);
        chk_want_png.Name = "chk_want_png";
        chk_want_png.Size = new Size(218, 26);
        chk_want_png.TabIndex = 21;
        chk_want_png.Text = "Построить график (PNG)";
        chk_want_png.UseVisualStyleBackColor = true;
        // 
        // cmbx_output_units
        // 
        cmbx_output_units.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbx_output_units.FormattingEnabled = true;
        cmbx_output_units.Items.AddRange(new object[] { "град", "мград", "ΔA", "Δε" });
        cmbx_output_units.Location = new Point(175, 80);
        cmbx_output_units.Name = "cmbx_output_units";
        cmbx_output_units.Size = new Size(118, 30);
        cmbx_output_units.TabIndex = 22;
        // 
        // label_output_units
        // 
        label_output_units.AutoSize = true;
        label_output_units.Location = new Point(13, 84);
        label_output_units.Name = "label_output_units";
        label_output_units.Size = new Size(148, 22);
        label_output_units.TabIndex = 23;
        label_output_units.Text = "Единицы вывода:";
        // 
        // btn_calculate
        // 
        btn_calculate.BackColor = Color.LightSteelBlue;
        btn_calculate.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)204));
        btn_calculate.Location = new Point(435, 450);
        btn_calculate.Name = "btn_calculate";
        btn_calculate.Size = new Size(360, 50);
        btn_calculate.TabIndex = 24;
        btn_calculate.Text = "Сформировать JSON";
        btn_calculate.UseVisualStyleBackColor = false;
        // 
        // lbl_status
        // 
        lbl_status.AutoSize = true;
        lbl_status.Font = new Font("Times New Roman", 12F, FontStyle.Italic, GraphicsUnit.Point, ((byte)204));
        lbl_status.ForeColor = Color.DarkSlateGray;
        lbl_status.Location = new Point(435, 510);
        lbl_status.Name = "lbl_status";
        lbl_status.Size = new Size(73, 22);
        lbl_status.TabIndex = 25;
        lbl_status.Text = "Готово";
        // 
        // grp_formulas
        // 
        grp_formulas.Controls.Add(rtb_formulas);
        grp_formulas.Location = new Point(810, 12);
        grp_formulas.Name = "grp_formulas";
        grp_formulas.Size = new Size(410, 543);
        grp_formulas.TabIndex = 26;
        grp_formulas.TabStop = false;
        grp_formulas.Text = "Справочник формул";
        // 
        // rtb_formulas
        // 
        rtb_formulas.BackColor = SystemColors.ControlLightLight;
        rtb_formulas.BorderStyle = BorderStyle.None;
        rtb_formulas.Dock = DockStyle.Fill;
        rtb_formulas.Font = new Font("Cambria Math", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)204));
        rtb_formulas.Location = new Point(3, 26);
        rtb_formulas.Name = "rtb_formulas";
        rtb_formulas.ReadOnly = true;
        rtb_formulas.Size = new Size(404, 514);
        rtb_formulas.TabIndex = 27;
        rtb_formulas.Text = "";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(11F, 22F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1235, 570);
        Controls.Add(grp_formulas);
        Controls.Add(lbl_status);
        Controls.Add(btn_calculate);
        Controls.Add(grp_output);
        Controls.Add(grp_medium);
        Controls.Add(grp_experiment);
        Controls.Add(grp_task);
        Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)204));
        Margin = new Padding(4, 3, 4, 3);
        Text = "\"Левые\"-\"Правые\" оптические среды";
        grp_task.ResumeLayout(false);
        grp_task.PerformLayout();
        grp_experiment.ResumeLayout(false);
        grp_experiment.PerformLayout();
        grp_medium.ResumeLayout(false);
        grp_medium.PerformLayout();
        grp_output.ResumeLayout(false);
        grp_output.PerformLayout();
        grp_formulas.ResumeLayout(false);
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
    private DataGridView dgv_table_lanes;
    
    // Переименованные лейблы
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

    // Новые элементы
    private GroupBox grp_task;
    private GroupBox grp_experiment;
    private GroupBox grp_medium;
    private GroupBox grp_output;
    private GroupBox grp_formulas;
    private CheckBox chk_want_json;
    private CheckBox chk_want_png;
    private ComboBox cmbx_output_units;
    private Button btn_calculate;
    private Label lbl_status;
    private RichTextBox rtb_formulas;
}