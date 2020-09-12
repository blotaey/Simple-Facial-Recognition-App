namespace Simple_Facial_Recognition_App
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnDetectFaces = new System.Windows.Forms.Button();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.picDetected = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.Location = new System.Drawing.Point(9, 10);
            this.picCapture.Margin = new System.Windows.Forms.Padding(2);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(648, 379);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(662, 10);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(131, 28);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "1. Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnDetectFaces
            // 
            this.btnDetectFaces.Location = new System.Drawing.Point(662, 42);
            this.btnDetectFaces.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetectFaces.Name = "btnDetectFaces";
            this.btnDetectFaces.Size = new System.Drawing.Size(131, 30);
            this.btnDetectFaces.TabIndex = 2;
            this.btnDetectFaces.Text = "2. Detect Faces";
            this.btnDetectFaces.UseVisualStyleBackColor = true;
            this.btnDetectFaces.Click += new System.EventHandler(this.btnDetectFaces_Click);
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(662, 225);
            this.txtPersonName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(132, 20);
            this.txtPersonName.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(662, 248);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 28);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "3. Save Person";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(662, 280);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(131, 31);
            this.btnTrain.TabIndex = 6;
            this.btnTrain.Text = "4. Train Images";
            this.btnTrain.UseVisualStyleBackColor = true;
            // 
            // btnRecognize
            // 
            this.btnRecognize.Location = new System.Drawing.Point(662, 316);
            this.btnRecognize.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(131, 29);
            this.btnRecognize.TabIndex = 7;
            this.btnRecognize.Text = "5. Recognize Persons";
            this.btnRecognize.UseVisualStyleBackColor = true;
            // 
            // picDetected
            // 
            this.picDetected.Location = new System.Drawing.Point(662, 77);
            this.picDetected.Margin = new System.Windows.Forms.Padding(2);
            this.picDetected.Name = "picDetected";
            this.picDetected.Size = new System.Drawing.Size(131, 143);
            this.picDetected.TabIndex = 8;
            this.picDetected.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 403);
            this.Controls.Add(this.picDetected);
            this.Controls.Add(this.btnRecognize);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPersonName);
            this.Controls.Add(this.btnDetectFaces);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.picCapture);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnDetectFaces;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.PictureBox picDetected;
    }
}

