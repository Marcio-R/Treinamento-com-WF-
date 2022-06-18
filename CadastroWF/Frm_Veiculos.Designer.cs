namespace CadastroWF
{
    partial class Frm_Veiculos
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
            this.tb_listaCar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_listaCar
            // 
            this.tb_listaCar.Location = new System.Drawing.Point(12, 12);
            this.tb_listaCar.Multiline = true;
            this.tb_listaCar.Name = "tb_listaCar";
            this.tb_listaCar.Size = new System.Drawing.Size(271, 426);
            this.tb_listaCar.TabIndex = 0;
            // 
            // Frm_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 450);
            this.Controls.Add(this.tb_listaCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_Veiculos";
            this.Text = "Lista de Veiculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_listaCar;
    }
}