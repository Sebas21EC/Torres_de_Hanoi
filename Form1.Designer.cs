namespace Torre_De_Hanoi
{
    partial class frm_principal
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
            this.components = new System.ComponentModel.Container();
            this.txt_numero_platos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.pnl_2 = new System.Windows.Forms.Panel();
            this.pnl_3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_movimiento = new System.Windows.Forms.Label();
            this.tmr_Recursivo = new System.Windows.Forms.Timer(this.components);
            this.btn_resolver = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_numero_platos
            // 
            this.txt_numero_platos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero_platos.Location = new System.Drawing.Point(225, 12);
            this.txt_numero_platos.Name = "txt_numero_platos";
            this.txt_numero_platos.Size = new System.Drawing.Size(100, 26);
            this.txt_numero_platos.TabIndex = 0;
            this.txt_numero_platos.Text = "3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_1.Location = new System.Drawing.Point(21, 98);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(337, 258);
            this.pnl_1.TabIndex = 2;
            // 
            // pnl_2
            // 
            this.pnl_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnl_2.Location = new System.Drawing.Point(395, 98);
            this.pnl_2.Name = "pnl_2";
            this.pnl_2.Size = new System.Drawing.Size(337, 258);
            this.pnl_2.TabIndex = 3;
            // 
            // pnl_3
            // 
            this.pnl_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnl_3.Location = new System.Drawing.Point(770, 98);
            this.pnl_3.Name = "pnl_3";
            this.pnl_3.Size = new System.Drawing.Size(337, 258);
            this.pnl_3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(72, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(195, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 52);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(469, 387);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 52);
            this.button4.TabIndex = 6;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lime;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(594, 387);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 52);
            this.button5.TabIndex = 7;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Blue;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(848, 387);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 52);
            this.button6.TabIndex = 8;
            this.button6.Text = "1";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(959, 387);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 52);
            this.button7.TabIndex = 9;
            this.button7.Text = "2";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Torre 1 (Origen)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Torre 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(870, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Torre 3 (Destino)";
            // 
            // lbl_movimiento
            // 
            this.lbl_movimiento.AutoSize = true;
            this.lbl_movimiento.Location = new System.Drawing.Point(567, 20);
            this.lbl_movimiento.Name = "lbl_movimiento";
            this.lbl_movimiento.Size = new System.Drawing.Size(132, 13);
            this.lbl_movimiento.TabIndex = 13;
            this.lbl_movimiento.Text = "Número de movimientos: 0";
            // 
            // tmr_Recursivo
            // 
            this.tmr_Recursivo.Tick += new System.EventHandler(this.tmr_Recursivo_Tick);
            // 
            // btn_resolver
            // 
            this.btn_resolver.Location = new System.Drawing.Point(874, 15);
            this.btn_resolver.Name = "btn_resolver";
            this.btn_resolver.Size = new System.Drawing.Size(75, 23);
            this.btn_resolver.TabIndex = 14;
            this.btn_resolver.Text = "Resolver";
            this.btn_resolver.UseVisualStyleBackColor = true;
            this.btn_resolver.Click += new System.EventHandler(this.btn_resolver_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(970, 15);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(51, 23);
            this.btn_next.TabIndex = 15;
            this.btn_next.Text = ">>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 454);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_resolver);
            this.Controls.Add(this.lbl_movimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnl_3);
            this.Controls.Add(this.pnl_2);
            this.Controls.Add(this.pnl_1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_numero_platos);
            this.Name = "frm_principal";
            this.Text = "Torres  de Hanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_numero_platos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Panel pnl_2;
        private System.Windows.Forms.Panel pnl_3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_movimiento;
        private System.Windows.Forms.Timer tmr_Recursivo;
        private System.Windows.Forms.Button btn_resolver;
        private System.Windows.Forms.Button btn_next;
    }
}

