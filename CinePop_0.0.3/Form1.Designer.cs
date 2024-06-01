namespace CinePop_0._0._3
{
    partial class CinePop
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
            PosterHolder = new PictureBox();
            MovieTitleLabel = new Label();
            SynopsisTextLabel = new Label();
            filmsComboBox = new ComboBox();
            CinePop_Logo = new PictureBox();
            SynopsisLabel = new Label();
            RatingLabel = new Label();
            RatingTextLabel = new Label();
            LengthLabel = new Label();
            LengthTextLabel = new Label();
            GenereLabel = new Label();
            GenereTextLabel = new Label();
            ChosenDateTimeLabel = new Label();
            showTimesComboBox = new ComboBox();
            TicketsToBuyLabel = new Label();
            SelectedTicketsLabel = new Label();
            AddTicketButton = new Button();
            MinusTicketButton = new Button();
            BuyTicketsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PosterHolder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CinePop_Logo).BeginInit();
            SuspendLayout();
            // 
            // PosterHolder
            // 
            PosterHolder.Image = Properties.Resources.F00001;
            PosterHolder.Location = new Point(38, 142);
            PosterHolder.Name = "PosterHolder";
            PosterHolder.Size = new Size(185, 275);
            PosterHolder.SizeMode = PictureBoxSizeMode.StretchImage;
            PosterHolder.TabIndex = 0;
            PosterHolder.TabStop = false;
            // 
            // MovieTitleLabel
            // 
            MovieTitleLabel.AutoSize = true;
            MovieTitleLabel.Font = new Font("Corbel", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MovieTitleLabel.ForeColor = Color.White;
            MovieTitleLabel.Location = new Point(250, 142);
            MovieTitleLabel.MaximumSize = new Size(250, 0);
            MovieTitleLabel.Name = "MovieTitleLabel";
            MovieTitleLabel.Size = new Size(175, 24);
            MovieTitleLabel.TabIndex = 1;
            MovieTitleLabel.Text = "Título de la película";
            MovieTitleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SynopsisTextLabel
            // 
            SynopsisTextLabel.AutoSize = true;
            SynopsisTextLabel.Font = new Font("Corbel", 9F);
            SynopsisTextLabel.ForeColor = Color.White;
            SynopsisTextLabel.Location = new Point(250, 228);
            SynopsisTextLabel.MaximumSize = new Size(250, 0);
            SynopsisTextLabel.Name = "SynopsisTextLabel";
            SynopsisTextLabel.Size = new Size(101, 14);
            SynopsisTextLabel.TabIndex = 2;
            SynopsisTextLabel.Text = "Título de la película";
            SynopsisTextLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // filmsComboBox
            // 
            filmsComboBox.FormattingEnabled = true;
            filmsComboBox.Location = new Point(507, 142);
            filmsComboBox.Name = "filmsComboBox";
            filmsComboBox.Size = new Size(196, 23);
            filmsComboBox.TabIndex = 3;
            filmsComboBox.SelectedIndexChanged += filmsComboBox_SelectedIndexChanged;
            // 
            // CinePop_Logo
            // 
            CinePop_Logo.Image = Properties.Resources.CinePop_Logo;
            CinePop_Logo.Location = new Point(250, 12);
            CinePop_Logo.Name = "CinePop_Logo";
            CinePop_Logo.Size = new Size(240, 80);
            CinePop_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            CinePop_Logo.TabIndex = 4;
            CinePop_Logo.TabStop = false;
            // 
            // SynopsisLabel
            // 
            SynopsisLabel.AutoSize = true;
            SynopsisLabel.Font = new Font("Corbel", 12F, FontStyle.Bold);
            SynopsisLabel.ForeColor = Color.White;
            SynopsisLabel.Location = new Point(250, 205);
            SynopsisLabel.MaximumSize = new Size(250, 0);
            SynopsisLabel.Name = "SynopsisLabel";
            SynopsisLabel.Size = new Size(67, 19);
            SynopsisLabel.TabIndex = 5;
            SynopsisLabel.Text = "Sinopsis";
            SynopsisLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RatingLabel
            // 
            RatingLabel.AutoSize = true;
            RatingLabel.Font = new Font("Corbel", 12F, FontStyle.Bold);
            RatingLabel.ForeColor = Color.White;
            RatingLabel.Location = new Point(250, 360);
            RatingLabel.MaximumSize = new Size(250, 0);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(94, 19);
            RatingLabel.TabIndex = 7;
            RatingLabel.Text = "Clasificación";
            RatingLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RatingTextLabel
            // 
            RatingTextLabel.AutoSize = true;
            RatingTextLabel.Font = new Font("Corbel", 10F);
            RatingTextLabel.ForeColor = Color.White;
            RatingTextLabel.Location = new Point(250, 385);
            RatingTextLabel.MaximumSize = new Size(250, 0);
            RatingTextLabel.Name = "RatingTextLabel";
            RatingTextLabel.Size = new Size(13, 17);
            RatingTextLabel.TabIndex = 6;
            RatingTextLabel.Text = "-";
            RatingTextLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Font = new Font("Corbel", 12F, FontStyle.Bold);
            LengthLabel.ForeColor = Color.White;
            LengthLabel.Location = new Point(390, 360);
            LengthLabel.MaximumSize = new Size(250, 0);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(72, 19);
            LengthLabel.TabIndex = 9;
            LengthLabel.Text = "Duración";
            LengthLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LengthTextLabel
            // 
            LengthTextLabel.AutoSize = true;
            LengthTextLabel.Font = new Font("Corbel", 10F);
            LengthTextLabel.ForeColor = Color.White;
            LengthTextLabel.Location = new Point(390, 385);
            LengthTextLabel.MaximumSize = new Size(250, 0);
            LengthTextLabel.Name = "LengthTextLabel";
            LengthTextLabel.Size = new Size(13, 17);
            LengthTextLabel.TabIndex = 8;
            LengthTextLabel.Text = "-";
            LengthTextLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GenereLabel
            // 
            GenereLabel.AutoSize = true;
            GenereLabel.Font = new Font("Corbel", 12F, FontStyle.Bold);
            GenereLabel.ForeColor = Color.White;
            GenereLabel.Location = new Point(250, 418);
            GenereLabel.MaximumSize = new Size(250, 0);
            GenereLabel.Name = "GenereLabel";
            GenereLabel.Size = new Size(60, 19);
            GenereLabel.TabIndex = 11;
            GenereLabel.Text = "Género";
            GenereLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GenereTextLabel
            // 
            GenereTextLabel.AutoSize = true;
            GenereTextLabel.Font = new Font("Corbel", 10F);
            GenereTextLabel.ForeColor = Color.White;
            GenereTextLabel.Location = new Point(250, 443);
            GenereTextLabel.MaximumSize = new Size(250, 0);
            GenereTextLabel.Name = "GenereTextLabel";
            GenereTextLabel.Size = new Size(13, 17);
            GenereTextLabel.TabIndex = 10;
            GenereTextLabel.Text = "-";
            GenereTextLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ChosenDateTimeLabel
            // 
            ChosenDateTimeLabel.AutoSize = true;
            ChosenDateTimeLabel.Font = new Font("Corbel", 12F, FontStyle.Bold);
            ChosenDateTimeLabel.ForeColor = Color.White;
            ChosenDateTimeLabel.Location = new Point(507, 181);
            ChosenDateTimeLabel.MaximumSize = new Size(250, 0);
            ChosenDateTimeLabel.Name = "ChosenDateTimeLabel";
            ChosenDateTimeLabel.Size = new Size(49, 19);
            ChosenDateTimeLabel.TabIndex = 12;
            ChosenDateTimeLabel.Text = "Fecha";
            ChosenDateTimeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // showTimesComboBox
            // 
            showTimesComboBox.FormattingEnabled = true;
            showTimesComboBox.Location = new Point(507, 205);
            showTimesComboBox.Name = "showTimesComboBox";
            showTimesComboBox.Size = new Size(196, 23);
            showTimesComboBox.TabIndex = 13;
            showTimesComboBox.SelectedIndexChanged += showTimesComboBox_SelectedIndexChanged;
            // 
            // TicketsToBuyLabel
            // 
            TicketsToBuyLabel.AutoSize = true;
            TicketsToBuyLabel.Font = new Font("Corbel", 12F, FontStyle.Bold);
            TicketsToBuyLabel.ForeColor = Color.White;
            TicketsToBuyLabel.Location = new Point(507, 255);
            TicketsToBuyLabel.MaximumSize = new Size(250, 0);
            TicketsToBuyLabel.Name = "TicketsToBuyLabel";
            TicketsToBuyLabel.Size = new Size(135, 19);
            TicketsToBuyLabel.TabIndex = 14;
            TicketsToBuyLabel.Text = "Boletos a comprar";
            TicketsToBuyLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SelectedTicketsLabel
            // 
            SelectedTicketsLabel.AutoSize = true;
            SelectedTicketsLabel.Font = new Font("Corbel", 16F, FontStyle.Bold);
            SelectedTicketsLabel.ForeColor = Color.White;
            SelectedTicketsLabel.Location = new Point(577, 295);
            SelectedTicketsLabel.MaximumSize = new Size(250, 0);
            SelectedTicketsLabel.Name = "SelectedTicketsLabel";
            SelectedTicketsLabel.Size = new Size(19, 27);
            SelectedTicketsLabel.TabIndex = 15;
            SelectedTicketsLabel.Text = "-";
            SelectedTicketsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddTicketButton
            // 
            AddTicketButton.Font = new Font("Corbel", 16F, FontStyle.Bold);
            AddTicketButton.Location = new Point(507, 288);
            AddTicketButton.Name = "AddTicketButton";
            AddTicketButton.Size = new Size(49, 40);
            AddTicketButton.TabIndex = 16;
            AddTicketButton.Text = "+";
            AddTicketButton.UseVisualStyleBackColor = true;
            AddTicketButton.Click += AddTicketButton_Click;
            // 
            // MinusTicketButton
            // 
            MinusTicketButton.Font = new Font("Corbel", 16F, FontStyle.Bold);
            MinusTicketButton.Location = new Point(621, 288);
            MinusTicketButton.Name = "MinusTicketButton";
            MinusTicketButton.Size = new Size(49, 40);
            MinusTicketButton.TabIndex = 17;
            MinusTicketButton.Text = "-";
            MinusTicketButton.UseVisualStyleBackColor = true;
            MinusTicketButton.Click += MinusTicketButton_Click;
            // 
            // BuyTicketsButton
            // 
            BuyTicketsButton.Font = new Font("Corbel", 12F, FontStyle.Bold);
            BuyTicketsButton.Location = new Point(507, 349);
            BuyTicketsButton.Name = "BuyTicketsButton";
            BuyTicketsButton.Size = new Size(98, 30);
            BuyTicketsButton.TabIndex = 18;
            BuyTicketsButton.Text = "Comprar";
            BuyTicketsButton.UseVisualStyleBackColor = true;
            BuyTicketsButton.Click += BuyTicketsButton_Click;
            // 
            // CinePop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 52, 56);
            ClientSize = new Size(747, 487);
            Controls.Add(BuyTicketsButton);
            Controls.Add(MinusTicketButton);
            Controls.Add(AddTicketButton);
            Controls.Add(SelectedTicketsLabel);
            Controls.Add(TicketsToBuyLabel);
            Controls.Add(showTimesComboBox);
            Controls.Add(ChosenDateTimeLabel);
            Controls.Add(GenereLabel);
            Controls.Add(GenereTextLabel);
            Controls.Add(LengthLabel);
            Controls.Add(LengthTextLabel);
            Controls.Add(RatingLabel);
            Controls.Add(RatingTextLabel);
            Controls.Add(SynopsisLabel);
            Controls.Add(CinePop_Logo);
            Controls.Add(filmsComboBox);
            Controls.Add(SynopsisTextLabel);
            Controls.Add(MovieTitleLabel);
            Controls.Add(PosterHolder);
            ForeColor = Color.FromArgb(47, 52, 56);
            Name = "CinePop";
            Text = "CinePop.com";
            Load += CinePop_Load;
            ((System.ComponentModel.ISupportInitialize)PosterHolder).EndInit();
            ((System.ComponentModel.ISupportInitialize)CinePop_Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PosterHolder;
        private Label MovieTitleLabel;
        private Label SynopsisTextLabel;
        private ComboBox filmsComboBox;
        private PictureBox CinePop_Logo;
        private Label SynopsisLabel;
        private Label RatingLabel;
        private Label RatingTextLabel;
        private Label LengthLabel;
        private Label LengthTextLabel;
        private Label GenereLabel;
        private Label GenereTextLabel;
        private Label ChosenDateTimeLabel;
        private ComboBox showTimesComboBox;
        private Label TicketsToBuyLabel;
        private Label SelectedTicketsLabel;
        private Button AddTicketButton;
        private Button MinusTicketButton;
        private Button BuyTicketsButton;
    }
}
