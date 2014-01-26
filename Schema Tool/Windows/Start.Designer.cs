namespace SchemaTool.Windows
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            System.Windows.Forms.Button btnRead;
            System.Windows.Forms.Button btnDesign;
            System.Windows.Forms.GroupBox groupBox;
            btnRead = new System.Windows.Forms.Button();
            btnDesign = new System.Windows.Forms.Button();
            groupBox = new System.Windows.Forms.GroupBox();
            groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new System.Drawing.Point(6, 48);
            btnRead.Name = "btnRead";
            btnRead.Size = new System.Drawing.Size(185, 23);
            btnRead.TabIndex = 1;
            btnRead.Text = "Read a File using a Schema";
            btnRead.UseVisualStyleBackColor = true;
            // 
            // btnDesign
            // 
            btnDesign.Location = new System.Drawing.Point(6, 19);
            btnDesign.Name = "btnDesign";
            btnDesign.Size = new System.Drawing.Size(185, 23);
            btnDesign.TabIndex = 0;
            btnDesign.Text = "Design a Schema";
            btnDesign.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(btnRead);
            groupBox.Controls.Add(btnDesign);
            groupBox.Location = new System.Drawing.Point(12, 12);
            groupBox.Name = "groupBox";
            groupBox.Size = new System.Drawing.Size(197, 187);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Options";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 211);
            this.Controls.Add(groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Start";
            this.Text = "Binary Schema Tool :: Start";
            groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

    }
}