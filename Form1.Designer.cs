namespace Utilities
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsimExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsimAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblIndicator = new System.Windows.Forms.Label();
            this.nudMinRandomRange = new System.Windows.Forms.NumericUpDown();
            this.nudMaxRandomRange = new System.Windows.Forms.NumericUpDown();
            this.btnRandom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRandom = new System.Windows.Forms.Label();
            this.tbRandomList = new System.Windows.Forms.TextBox();
            this.btnRandomClear = new System.Windows.Forms.Button();
            this.btnRandomCopy = new System.Windows.Forms.Button();
            this.cbRandomIsRepeat = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbNotepad = new System.Windows.Forms.RichTextBox();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiInsertDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSaveNotepad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoadNotepad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinRandomRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxRandomRange)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsimExit});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(71, 29);
            this.toolStripDropDownButton1.Text = "Файл";
            // 
            // tsimExit
            // 
            this.tsimExit.Name = "tsimExit";
            this.tsimExit.Size = new System.Drawing.Size(148, 30);
            this.tsimExit.Text = "Выход";
            this.tsimExit.Click += new System.EventHandler(this.tsimExit_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsimAbout});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(102, 29);
            this.toolStripDropDownButton2.Text = "Помощь";
            // 
            // tsimAbout
            // 
            this.tsimAbout.Name = "tsimAbout";
            this.tsimAbout.Size = new System.Drawing.Size(252, 30);
            this.tsimAbout.Text = "О программе";
            this.tsimAbout.Click += new System.EventHandler(this.tsimAbout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 414);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblIndicator);
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.btnMinus);
            this.tabPage1.Controls.Add(this.btnPlus);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Счетчик";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbRandomIsRepeat);
            this.tabPage2.Controls.Add(this.btnRandomCopy);
            this.tabPage2.Controls.Add(this.btnRandomClear);
            this.tabPage2.Controls.Add(this.tbRandomList);
            this.tabPage2.Controls.Add(this.lblRandom);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnRandom);
            this.tabPage2.Controls.Add(this.nudMaxRandomRange);
            this.tabPage2.Controls.Add(this.nudMinRandomRange);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Генератор";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(53, 36);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(90, 37);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(53, 142);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(90, 37);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(176, 89);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 37);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Сброс";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // lblIndicator
            // 
            this.lblIndicator.AutoSize = true;
            this.lblIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIndicator.Location = new System.Drawing.Point(80, 89);
            this.lblIndicator.Name = "lblIndicator";
            this.lblIndicator.Size = new System.Drawing.Size(36, 37);
            this.lblIndicator.TabIndex = 3;
            this.lblIndicator.Text = "0";
            // 
            // nudMinRandomRange
            // 
            this.nudMinRandomRange.Location = new System.Drawing.Point(68, 33);
            this.nudMinRandomRange.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudMinRandomRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinRandomRange.Name = "nudMinRandomRange";
            this.nudMinRandomRange.Size = new System.Drawing.Size(77, 26);
            this.nudMinRandomRange.TabIndex = 0;
            this.nudMinRandomRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMaxRandomRange
            // 
            this.nudMaxRandomRange.Location = new System.Drawing.Point(68, 106);
            this.nudMaxRandomRange.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudMaxRandomRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxRandomRange.Name = "nudMaxRandomRange";
            this.nudMaxRandomRange.Size = new System.Drawing.Size(77, 26);
            this.nudMaxRandomRange.TabIndex = 1;
            this.nudMaxRandomRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(218, 33);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 30);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Задать";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "От:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "До:";
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(225, 112);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(18, 20);
            this.lblRandom.TabIndex = 5;
            this.lblRandom.Text = "0";
            // 
            // tbRandomList
            // 
            this.tbRandomList.Location = new System.Drawing.Point(218, 138);
            this.tbRandomList.Multiline = true;
            this.tbRandomList.Name = "tbRandomList";
            this.tbRandomList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRandomList.Size = new System.Drawing.Size(100, 157);
            this.tbRandomList.TabIndex = 6;
            // 
            // btnRandomClear
            // 
            this.btnRandomClear.Location = new System.Drawing.Point(24, 163);
            this.btnRandomClear.Name = "btnRandomClear";
            this.btnRandomClear.Size = new System.Drawing.Size(113, 34);
            this.btnRandomClear.TabIndex = 7;
            this.btnRandomClear.Text = "Очистить";
            this.btnRandomClear.UseVisualStyleBackColor = true;
            this.btnRandomClear.Click += new System.EventHandler(this.BtnRandomClear_Click);
            // 
            // btnRandomCopy
            // 
            this.btnRandomCopy.Location = new System.Drawing.Point(24, 213);
            this.btnRandomCopy.Name = "btnRandomCopy";
            this.btnRandomCopy.Size = new System.Drawing.Size(113, 35);
            this.btnRandomCopy.TabIndex = 8;
            this.btnRandomCopy.Text = "Копировать";
            this.btnRandomCopy.UseVisualStyleBackColor = true;
            this.btnRandomCopy.Click += new System.EventHandler(this.BtnRandomCopy_Click);
            // 
            // cbRandomIsRepeat
            // 
            this.cbRandomIsRepeat.AutoSize = true;
            this.cbRandomIsRepeat.Location = new System.Drawing.Point(24, 271);
            this.cbRandomIsRepeat.Name = "cbRandomIsRepeat";
            this.cbRandomIsRepeat.Size = new System.Drawing.Size(155, 24);
            this.cbRandomIsRepeat.TabIndex = 9;
            this.cbRandomIsRepeat.Text = "без повторений";
            this.cbRandomIsRepeat.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbNotepad);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 381);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Блокнот";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbNotepad
            // 
            this.rtbNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotepad.Location = new System.Drawing.Point(3, 3);
            this.rtbNotepad.Name = "rtbNotepad";
            this.rtbNotepad.Size = new System.Drawing.Size(786, 375);
            this.rtbNotepad.TabIndex = 0;
            this.rtbNotepad.Text = "";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInsertDate,
            this.tsmiInsertTime,
            this.toolStripMenuItem1,
            this.tsmiSaveNotepad,
            this.tsmiLoadNotepad});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(97, 29);
            this.toolStripDropDownButton3.Text = "Блокнот";
            // 
            // tsmiInsertDate
            // 
            this.tsmiInsertDate.Name = "tsmiInsertDate";
            this.tsmiInsertDate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsmiInsertDate.Size = new System.Drawing.Size(331, 30);
            this.tsmiInsertDate.Text = "Вставить дату";
            this.tsmiInsertDate.Click += new System.EventHandler(this.TsmiInsertDate_Click);
            // 
            // tsmiInsertTime
            // 
            this.tsmiInsertTime.Name = "tsmiInsertTime";
            this.tsmiInsertTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tsmiInsertTime.Size = new System.Drawing.Size(331, 30);
            this.tsmiInsertTime.Text = "Вставить время";
            this.tsmiInsertTime.Click += new System.EventHandler(this.TsmiInsertTime_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(328, 6);
            // 
            // tsmiSaveNotepad
            // 
            this.tsmiSaveNotepad.Name = "tsmiSaveNotepad";
            this.tsmiSaveNotepad.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiSaveNotepad.Size = new System.Drawing.Size(331, 30);
            this.tsmiSaveNotepad.Text = "Сохранить";
            this.tsmiSaveNotepad.Click += new System.EventHandler(this.TsmiSaveNotepad_Click);
            // 
            // tsmiLoadNotepad
            // 
            this.tsmiLoadNotepad.Name = "tsmiLoadNotepad";
            this.tsmiLoadNotepad.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.tsmiLoadNotepad.Size = new System.Drawing.Size(331, 30);
            this.tsmiLoadNotepad.Text = "Загрузить";
            this.tsmiLoadNotepad.Click += new System.EventHandler(this.TsmiLoadNotepad_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Мои утилиты";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinRandomRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxRandomRange)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem tsimExit;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem tsimAbout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblIndicator;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.NumericUpDown nudMaxRandomRange;
        private System.Windows.Forms.NumericUpDown nudMinRandomRange;
        private System.Windows.Forms.CheckBox cbRandomIsRepeat;
        private System.Windows.Forms.Button btnRandomCopy;
        private System.Windows.Forms.Button btnRandomClear;
        private System.Windows.Forms.TextBox tbRandomList;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveNotepad;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadNotepad;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtbNotepad;
    }
}

