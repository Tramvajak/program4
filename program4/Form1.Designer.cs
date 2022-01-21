
namespace program4
{
    partial class Form1
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
            this.btn_SaveText = new System.Windows.Forms.Button();
            this.btn_CreateSignature = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.text_Sigrature = new System.Windows.Forms.TextBox();
            this.btn_LoadText = new System.Windows.Forms.Button();
            this.btn_LoadSignature = new System.Windows.Forms.Button();
            this.btn_Verify = new System.Windows.Forms.Button();
            this.btn_SaveSignature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SaveText
            // 
            this.btn_SaveText.Location = new System.Drawing.Point(38, 12);
            this.btn_SaveText.Name = "btn_SaveText";
            this.btn_SaveText.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveText.TabIndex = 0;
            this.btn_SaveText.Text = "Save Text";
            this.btn_SaveText.UseVisualStyleBackColor = true;
            this.btn_SaveText.Click += new System.EventHandler(this.btn_SaveText_Click);
            // 
            // btn_CreateSignature
            // 
            this.btn_CreateSignature.Location = new System.Drawing.Point(389, 70);
            this.btn_CreateSignature.Name = "btn_CreateSignature";
            this.btn_CreateSignature.Size = new System.Drawing.Size(94, 23);
            this.btn_CreateSignature.TabIndex = 1;
            this.btn_CreateSignature.Text = "Create Signature";
            this.btn_CreateSignature.UseVisualStyleBackColor = true;
            this.btn_CreateSignature.Click += new System.EventHandler(this.btn_CreateSignature_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(145, 14);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(605, 50);
            this.TextBox.TabIndex = 2;
            // 
            // text_Sigrature
            // 
            this.text_Sigrature.Location = new System.Drawing.Point(145, 99);
            this.text_Sigrature.Multiline = true;
            this.text_Sigrature.Name = "text_Sigrature";
            this.text_Sigrature.ReadOnly = true;
            this.text_Sigrature.Size = new System.Drawing.Size(605, 49);
            this.text_Sigrature.TabIndex = 3;
            // 
            // btn_LoadText
            // 
            this.btn_LoadText.Location = new System.Drawing.Point(38, 41);
            this.btn_LoadText.Name = "btn_LoadText";
            this.btn_LoadText.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadText.TabIndex = 4;
            this.btn_LoadText.Text = "Load Text";
            this.btn_LoadText.UseVisualStyleBackColor = true;
            this.btn_LoadText.Click += new System.EventHandler(this.btn_LoadText_Click);
            // 
            // btn_LoadSignature
            // 
            this.btn_LoadSignature.Location = new System.Drawing.Point(29, 125);
            this.btn_LoadSignature.Name = "btn_LoadSignature";
            this.btn_LoadSignature.Size = new System.Drawing.Size(94, 23);
            this.btn_LoadSignature.TabIndex = 5;
            this.btn_LoadSignature.Text = "Load Signature";
            this.btn_LoadSignature.UseVisualStyleBackColor = true;
            this.btn_LoadSignature.Click += new System.EventHandler(this.btn_LoadSignature_Click);
            // 
            // btn_Verify
            // 
            this.btn_Verify.Location = new System.Drawing.Point(376, 154);
            this.btn_Verify.Name = "btn_Verify";
            this.btn_Verify.Size = new System.Drawing.Size(120, 23);
            this.btn_Verify.TabIndex = 6;
            this.btn_Verify.Text = "Verify";
            this.btn_Verify.UseVisualStyleBackColor = true;
            this.btn_Verify.Click += new System.EventHandler(this.btn_Verify_Click);
            // 
            // btn_SaveSignature
            // 
            this.btn_SaveSignature.Location = new System.Drawing.Point(29, 96);
            this.btn_SaveSignature.Name = "btn_SaveSignature";
            this.btn_SaveSignature.Size = new System.Drawing.Size(94, 23);
            this.btn_SaveSignature.TabIndex = 7;
            this.btn_SaveSignature.Text = "Save Signature";
            this.btn_SaveSignature.UseVisualStyleBackColor = true;
            this.btn_SaveSignature.Click += new System.EventHandler(this.btn_SaveSignature_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 209);
            this.Controls.Add(this.btn_SaveSignature);
            this.Controls.Add(this.btn_Verify);
            this.Controls.Add(this.btn_LoadSignature);
            this.Controls.Add(this.btn_LoadText);
            this.Controls.Add(this.text_Sigrature);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.btn_CreateSignature);
            this.Controls.Add(this.btn_SaveText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SaveText;
        private System.Windows.Forms.Button btn_CreateSignature;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.TextBox text_Sigrature;
        private System.Windows.Forms.Button btn_LoadText;
        private System.Windows.Forms.Button btn_LoadSignature;
        private System.Windows.Forms.Button btn_Verify;
        private System.Windows.Forms.Button btn_SaveSignature;
    }
}

