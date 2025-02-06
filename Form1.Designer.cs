namespace TitansHashdictionaryReader
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RouteTextBox = new System.Windows.Forms.TextBox();
            this.RouteSearchButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.StartButton = new System.Windows.Forms.Button();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.ConsoleTextBox = new System.Windows.Forms.TextBox();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.FailedLabel = new System.Windows.Forms.Label();
            this.AlreadyExistsLabel = new System.Windows.Forms.Label();
            this.NotFoundLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.radioDefault = new System.Windows.Forms.RadioButton();
            this.radioDelete = new System.Windows.Forms.RadioButton();
            this.radioDuplicates = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // RouteTextBox
            // 
            this.RouteTextBox.AllowDrop = true;
            this.RouteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteTextBox.Location = new System.Drawing.Point(13, 13);
            this.RouteTextBox.Name = "RouteTextBox";
            this.RouteTextBox.Size = new System.Drawing.Size(730, 26);
            this.RouteTextBox.TabIndex = 0;
            this.RouteTextBox.Text = "Place route here.";
            this.RouteTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.RouteTextBox_DragDrop);
            this.RouteTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.RouteTextBox_DragEnter);
            // 
            // RouteSearchButton
            // 
            this.RouteSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RouteSearchButton.Location = new System.Drawing.Point(749, 13);
            this.RouteSearchButton.Name = "RouteSearchButton";
            this.RouteSearchButton.Size = new System.Drawing.Size(39, 26);
            this.RouteSearchButton.TabIndex = 1;
            this.RouteSearchButton.Text = "...";
            this.RouteSearchButton.UseVisualStyleBackColor = true;
            this.RouteSearchButton.Click += new System.EventHandler(this.RouteSearchButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 46);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(694, 26);
            this.progressBar.TabIndex = 2;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(713, 45);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 26);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.Location = new System.Drawing.Point(13, 79);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(775, 61);
            this.InstructionsLabel.TabIndex = 4;
            this.InstructionsLabel.Text = resources.GetString("InstructionsLabel.Text");
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleTextBox.Location = new System.Drawing.Point(13, 173);
            this.ConsoleTextBox.Multiline = true;
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.ReadOnly = true;
            this.ConsoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConsoleTextBox.Size = new System.Drawing.Size(775, 122);
            this.ConsoleTextBox.TabIndex = 5;
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.AutoSize = true;
            this.SuccessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessLabel.Location = new System.Drawing.Point(13, 301);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(104, 20);
            this.SuccessLabel.TabIndex = 6;
            this.SuccessLabel.Text = "SUCCESS: 0";
            // 
            // FailedLabel
            // 
            this.FailedLabel.AutoSize = true;
            this.FailedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FailedLabel.Location = new System.Drawing.Point(163, 301);
            this.FailedLabel.Name = "FailedLabel";
            this.FailedLabel.Size = new System.Drawing.Size(84, 20);
            this.FailedLabel.TabIndex = 7;
            this.FailedLabel.Text = "FAILED: 0";
            // 
            // AlreadyExistsLabel
            // 
            this.AlreadyExistsLabel.AutoSize = true;
            this.AlreadyExistsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlreadyExistsLabel.Location = new System.Drawing.Point(458, 301);
            this.AlreadyExistsLabel.Name = "AlreadyExistsLabel";
            this.AlreadyExistsLabel.Size = new System.Drawing.Size(165, 20);
            this.AlreadyExistsLabel.TabIndex = 8;
            this.AlreadyExistsLabel.Text = "ALREADY EXISTS: 0";
            // 
            // NotFoundLabel
            // 
            this.NotFoundLabel.AutoSize = true;
            this.NotFoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotFoundLabel.Location = new System.Drawing.Point(293, 301);
            this.NotFoundLabel.Name = "NotFoundLabel";
            this.NotFoundLabel.Size = new System.Drawing.Size(119, 20);
            this.NotFoundLabel.TabIndex = 9;
            this.NotFoundLabel.Text = "NOT FOUND: 0";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(669, 301);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(76, 20);
            this.TotalLabel.TabIndex = 10;
            this.TotalLabel.Text = "TOTAL: 0";
            // 
            // radioDefault
            // 
            this.radioDefault.AutoSize = true;
            this.radioDefault.Checked = true;
            this.radioDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioDefault.Location = new System.Drawing.Point(13, 143);
            this.radioDefault.Name = "radioDefault";
            this.radioDefault.Size = new System.Drawing.Size(182, 24);
            this.radioDefault.TabIndex = 11;
            this.radioDefault.TabStop = true;
            this.radioDefault.Text = "Process files (Default)";
            this.radioDefault.UseVisualStyleBackColor = true;
            // 
            // radioDelete
            // 
            this.radioDelete.AutoSize = true;
            this.radioDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioDelete.Location = new System.Drawing.Point(227, 143);
            this.radioDelete.Name = "radioDelete";
            this.radioDelete.Size = new System.Drawing.Size(257, 24);
            this.radioDelete.TabIndex = 12;
            this.radioDelete.Text = "Process files and delete originals";
            this.radioDelete.UseVisualStyleBackColor = true;
            // 
            // radioDuplicates
            // 
            this.radioDuplicates.AutoSize = true;
            this.radioDuplicates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioDuplicates.Location = new System.Drawing.Point(516, 143);
            this.radioDuplicates.Name = "radioDuplicates";
            this.radioDuplicates.Size = new System.Drawing.Size(266, 24);
            this.radioDuplicates.TabIndex = 13;
            this.radioDuplicates.Text = "Find duplicates in Hash Dictionary";
            this.radioDuplicates.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.Controls.Add(this.radioDuplicates);
            this.Controls.Add(this.radioDelete);
            this.Controls.Add(this.radioDefault);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.NotFoundLabel);
            this.Controls.Add(this.AlreadyExistsLabel);
            this.Controls.Add(this.FailedLabel);
            this.Controls.Add(this.SuccessLabel);
            this.Controls.Add(this.ConsoleTextBox);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.RouteSearchButton);
            this.Controls.Add(this.RouteTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::TitansHashdictionaryReader.Properties.Resources.AppIcon;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Titans Hashdictionary Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RouteTextBox;
        private System.Windows.Forms.Button RouteSearchButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.TextBox ConsoleTextBox;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.Label FailedLabel;
        private System.Windows.Forms.Label AlreadyExistsLabel;
        private System.Windows.Forms.Label NotFoundLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.RadioButton radioDefault;
        private System.Windows.Forms.RadioButton radioDelete;
        private System.Windows.Forms.RadioButton radioDuplicates;
    }
}

