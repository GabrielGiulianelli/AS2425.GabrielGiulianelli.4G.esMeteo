namespace AS2425.GabrielGiulianelli._4G.esMeteo
{
    partial class Form1
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
            txtCity = new TextBox();
            txtOrario = new TextBox();
            txtData = new TextBox();
            lblCity = new Label();
            lblOrario = new Label();
            lblData = new Label();
            btnAggiungiPrenotazione = new Button();
            btnRefresh = new Button();
            dgvMeteo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMeteo).BeginInit();
            SuspendLayout();
            // 
            // txtCity
            // 
            txtCity.Location = new Point(183, 43);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(136, 27);
            txtCity.TabIndex = 0;
            // 
            // txtOrario
            // 
            txtOrario.Location = new Point(183, 99);
            txtOrario.Name = "txtOrario";
            txtOrario.Size = new Size(136, 27);
            txtOrario.TabIndex = 1;
            // 
            // txtData
            // 
            txtData.Location = new Point(183, 158);
            txtData.Name = "txtData";
            txtData.Size = new Size(136, 27);
            txtData.TabIndex = 2;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(90, 43);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(40, 20);
            lblCity.TabIndex = 3;
            lblCity.Text = "Città";
            // 
            // lblOrario
            // 
            lblOrario.AutoSize = true;
            lblOrario.Location = new Point(90, 106);
            lblOrario.Name = "lblOrario";
            lblOrario.Size = new Size(51, 20);
            lblOrario.TabIndex = 4;
            lblOrario.Text = "Orario";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(90, 165);
            lblData.Name = "lblData";
            lblData.Size = new Size(41, 20);
            lblData.TabIndex = 5;
            lblData.Text = "Data";
            // 
            // btnAggiungiPrenotazione
            // 
            btnAggiungiPrenotazione.Location = new Point(409, 55);
            btnAggiungiPrenotazione.Name = "btnAggiungiPrenotazione";
            btnAggiungiPrenotazione.Size = new Size(241, 123);
            btnAggiungiPrenotazione.TabIndex = 6;
            btnAggiungiPrenotazione.Text = "Inserisci una prenotazione di temperatura";
            btnAggiungiPrenotazione.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(296, 205);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(152, 39);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Aggiorna i dati";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dgvMeteo
            // 
            dgvMeteo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeteo.Location = new Point(90, 250);
            dgvMeteo.Name = "dgvMeteo";
            dgvMeteo.RowHeadersWidth = 51;
            dgvMeteo.Size = new Size(587, 188);
            dgvMeteo.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMeteo);
            Controls.Add(btnRefresh);
            Controls.Add(btnAggiungiPrenotazione);
            Controls.Add(lblData);
            Controls.Add(lblOrario);
            Controls.Add(lblCity);
            Controls.Add(txtData);
            Controls.Add(txtOrario);
            Controls.Add(txtCity);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvMeteo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCity;
        private TextBox txtOrario;
        private TextBox txtData;
        private Label lblCity;
        private Label lblOrario;
        private Label lblData;
        private Button btnAggiungiPrenotazione;
        private Button btnRefresh;
        private DataGridView dgvMeteo;
    }
}
