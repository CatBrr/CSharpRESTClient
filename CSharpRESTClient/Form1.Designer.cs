
namespace CSharpRESTClient
{
    partial class Form1
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
            this.textURL = new System.Windows.Forms.TextBox();
            this.textResponse = new System.Windows.Forms.TextBox();
            this.cmdGO = new System.Windows.Forms.Button();
            this.labelURL = new System.Windows.Forms.Label();
            this.Responcelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(130, 12);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(289, 20);
            this.textURL.TabIndex = 0;
            // 
            // textResponse
            // 
            this.textResponse.Location = new System.Drawing.Point(130, 38);
            this.textResponse.Multiline = true;
            this.textResponse.Name = "textResponse";
            this.textResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textResponse.Size = new System.Drawing.Size(418, 197);
            this.textResponse.TabIndex = 1;
            // 
            // cmdGO
            // 
            this.cmdGO.Location = new System.Drawing.Point(425, 9);
            this.cmdGO.Name = "cmdGO";
            this.cmdGO.Size = new System.Drawing.Size(75, 23);
            this.cmdGO.TabIndex = 2;
            this.cmdGO.Text = "MINE";
            this.cmdGO.UseVisualStyleBackColor = true;
            this.cmdGO.Click += new System.EventHandler(this.cmdGO_Click);
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(53, 19);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(58, 13);
            this.labelURL.TabIndex = 3;
            this.labelURL.Text = "URI päring";
            // 
            // Responcelabel
            // 
            this.Responcelabel.AutoSize = true;
            this.Responcelabel.Location = new System.Drawing.Point(53, 41);
            this.Responcelabel.Name = "Responcelabel";
            this.Responcelabel.Size = new System.Drawing.Size(39, 13);
            this.Responcelabel.TabIndex = 4;
            this.Responcelabel.Text = "Vastus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 266);
            this.Controls.Add(this.Responcelabel);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.cmdGO);
            this.Controls.Add(this.textResponse);
            this.Controls.Add(this.textURL);
            this.Name = "Form1";
            this.Text = "C# REST Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.TextBox textResponse;
        private System.Windows.Forms.Button cmdGO;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Label Responcelabel;
    }
}

