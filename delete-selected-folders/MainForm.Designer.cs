namespace delete_selected_folders
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxDocument = new System.Windows.Forms.CheckBox();
            this.checkBoxPicture = new System.Windows.Forms.CheckBox();
            this.checkBoxPersons = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxDocument
            // 
            this.checkBoxDocument.AutoSize = true;
            this.checkBoxDocument.Location = new System.Drawing.Point(34, 31);
            this.checkBoxDocument.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxDocument.Name = "checkBoxDocument";
            this.checkBoxDocument.Size = new System.Drawing.Size(152, 36);
            this.checkBoxDocument.TabIndex = 0;
            this.checkBoxDocument.Text = "Document";
            this.checkBoxDocument.UseVisualStyleBackColor = true;
            // 
            // checkBoxPicture
            // 
            this.checkBoxPicture.AutoSize = true;
            this.checkBoxPicture.Location = new System.Drawing.Point(34, 76);
            this.checkBoxPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPicture.Name = "checkBoxPicture";
            this.checkBoxPicture.Size = new System.Drawing.Size(113, 36);
            this.checkBoxPicture.TabIndex = 0;
            this.checkBoxPicture.Text = "Picture";
            this.checkBoxPicture.UseVisualStyleBackColor = true;
            // 
            // checkBoxPersons
            // 
            this.checkBoxPersons.AutoSize = true;
            this.checkBoxPersons.Location = new System.Drawing.Point(34, 121);
            this.checkBoxPersons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPersons.Name = "checkBoxPersons";
            this.checkBoxPersons.Size = new System.Drawing.Size(121, 36);
            this.checkBoxPersons.TabIndex = 0;
            this.checkBoxPersons.Text = "Persons";
            this.checkBoxPersons.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Maroon;
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(203, 172);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(139, 49);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 244);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.checkBoxPersons);
            this.Controls.Add(this.checkBoxPicture);
            this.Controls.Add(this.checkBoxDocument);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDocument;
        private System.Windows.Forms.CheckBox checkBoxPicture;
        private System.Windows.Forms.CheckBox checkBoxPersons;
        private System.Windows.Forms.Button buttonClear;
    }
}
