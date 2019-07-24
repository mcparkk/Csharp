namespace WindowsFormsApp2
{
    partial class FluentDesignForm1
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_volume_1day = new System.Windows.Forms.Label();
            this.label_opening_price = new System.Windows.Forms.Label();
            this.label_volume_7day = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_timestamp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_24H_fluctate_rate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_24H_fluctate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_sell_price = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_buy_price = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_units_traded = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_average_price = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_max_price = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_min_price = new System.Windows.Forms.Label();
            this.label_closing_price = new System.Windows.Forms.Label();
            this.h = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.chartControl1);
            this.fluentDesignFormContainer1.Controls.Add(this.panel1);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 36);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(808, 539);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // chartControl1
            // 
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Location = new System.Drawing.Point(22, 31);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.SeriesColorizer = null;
            this.chartControl1.Size = new System.Drawing.Size(273, 205);
            this.chartControl1.TabIndex = 31;
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_volume_1day);
            this.panel1.Controls.Add(this.label_opening_price);
            this.panel1.Controls.Add(this.label_volume_7day);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label_timestamp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label_24H_fluctate_rate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label_24H_fluctate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label_sell_price);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label_buy_price);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label_units_traded);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label_average_price);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label_max_price);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label_min_price);
            this.panel1.Controls.Add(this.label_closing_price);
            this.panel1.Location = new System.Drawing.Point(334, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 459);
            this.panel1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coin Name";
            // 
            // label_volume_1day
            // 
            this.label_volume_1day.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_volume_1day.AutoSize = true;
            this.label_volume_1day.Location = new System.Drawing.Point(360, 267);
            this.label_volume_1day.Name = "label_volume_1day";
            this.label_volume_1day.Size = new System.Drawing.Size(52, 18);
            this.label_volume_1day.TabIndex = 29;
            this.label_volume_1day.Text = "label21";
            // 
            // label_opening_price
            // 
            this.label_opening_price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_opening_price.AutoSize = true;
            this.label_opening_price.Location = new System.Drawing.Point(360, 67);
            this.label_opening_price.Name = "label_opening_price";
            this.label_opening_price.Size = new System.Drawing.Size(44, 18);
            this.label_opening_price.TabIndex = 1;
            this.label_opening_price.Text = "label2";
            // 
            // label_volume_7day
            // 
            this.label_volume_7day.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_volume_7day.AutoSize = true;
            this.label_volume_7day.Location = new System.Drawing.Point(360, 296);
            this.label_volume_7day.Name = "label_volume_7day";
            this.label_volume_7day.Size = new System.Drawing.Size(52, 18);
            this.label_volume_7day.TabIndex = 28;
            this.label_volume_7day.Text = "label21";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "시가";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(64, 382);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 18);
            this.label20.TabIndex = 27;
            this.label20.Text = "최근 24시 변동가";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "종가";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(64, 410);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 18);
            this.label19.TabIndex = 26;
            this.label19.Text = "최근 24시 변동률";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "저가";
            // 
            // label_timestamp
            // 
            this.label_timestamp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_timestamp.AutoSize = true;
            this.label_timestamp.Location = new System.Drawing.Point(360, 437);
            this.label_timestamp.Name = "label_timestamp";
            this.label_timestamp.Size = new System.Drawing.Size(52, 18);
            this.label_timestamp.TabIndex = 25;
            this.label_timestamp.Text = "label23";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "고가";
            // 
            // label_24H_fluctate_rate
            // 
            this.label_24H_fluctate_rate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_24H_fluctate_rate.AutoSize = true;
            this.label_24H_fluctate_rate.Location = new System.Drawing.Point(360, 410);
            this.label_24H_fluctate_rate.Name = "label_24H_fluctate_rate";
            this.label_24H_fluctate_rate.Size = new System.Drawing.Size(52, 18);
            this.label_24H_fluctate_rate.TabIndex = 24;
            this.label_24H_fluctate_rate.Text = "label22";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "평균가";
            // 
            // label_24H_fluctate
            // 
            this.label_24H_fluctate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_24H_fluctate.AutoSize = true;
            this.label_24H_fluctate.Location = new System.Drawing.Point(360, 382);
            this.label_24H_fluctate.Name = "label_24H_fluctate";
            this.label_24H_fluctate.Size = new System.Drawing.Size(52, 18);
            this.label_24H_fluctate.TabIndex = 23;
            this.label_24H_fluctate.Text = "label21";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "거래량";
            // 
            // label_sell_price
            // 
            this.label_sell_price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_sell_price.AutoSize = true;
            this.label_sell_price.Location = new System.Drawing.Point(360, 355);
            this.label_sell_price.Name = "label_sell_price";
            this.label_sell_price.Size = new System.Drawing.Size(52, 18);
            this.label_sell_price.TabIndex = 22;
            this.label_sell_price.Text = "label20";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Currency 거래량(최근 1일)";
            // 
            // label_buy_price
            // 
            this.label_buy_price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_buy_price.AutoSize = true;
            this.label_buy_price.Location = new System.Drawing.Point(360, 327);
            this.label_buy_price.Name = "label_buy_price";
            this.label_buy_price.Size = new System.Drawing.Size(52, 18);
            this.label_buy_price.TabIndex = 21;
            this.label_buy_price.Text = "label19";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Currency 거래량(최근 7일)";
            // 
            // label_units_traded
            // 
            this.label_units_traded.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_units_traded.AutoSize = true;
            this.label_units_traded.Location = new System.Drawing.Point(360, 234);
            this.label_units_traded.Name = "label_units_traded";
            this.label_units_traded.Size = new System.Drawing.Size(52, 18);
            this.label_units_traded.TabIndex = 20;
            this.label_units_traded.Text = "label18";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "거래 대기건 중 최고 구매가";
            // 
            // label_average_price
            // 
            this.label_average_price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_average_price.AutoSize = true;
            this.label_average_price.Location = new System.Drawing.Point(360, 204);
            this.label_average_price.Name = "label_average_price";
            this.label_average_price.Size = new System.Drawing.Size(52, 18);
            this.label_average_price.TabIndex = 19;
            this.label_average_price.Text = "label17";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 18);
            this.label12.TabIndex = 14;
            this.label12.Text = "거래 대기건 중 최저 판매가";
            // 
            // label_max_price
            // 
            this.label_max_price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_max_price.AutoSize = true;
            this.label_max_price.Location = new System.Drawing.Point(360, 172);
            this.label_max_price.Name = "label_max_price";
            this.label_max_price.Size = new System.Drawing.Size(52, 18);
            this.label_max_price.TabIndex = 18;
            this.label_max_price.Text = "label16";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 437);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 18);
            this.label13.TabIndex = 15;
            this.label13.Text = "타임 스탬프";
            // 
            // label_min_price
            // 
            this.label_min_price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_min_price.AutoSize = true;
            this.label_min_price.Location = new System.Drawing.Point(360, 135);
            this.label_min_price.Name = "label_min_price";
            this.label_min_price.Size = new System.Drawing.Size(52, 18);
            this.label_min_price.TabIndex = 17;
            this.label_min_price.Text = "label15";
            // 
            // label_closing_price
            // 
            this.label_closing_price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_closing_price.AutoSize = true;
            this.label_closing_price.Location = new System.Drawing.Point(360, 100);
            this.label_closing_price.Name = "label_closing_price";
            this.label_closing_price.Size = new System.Drawing.Size(52, 18);
            this.label_closing_price.TabIndex = 16;
            this.label_closing_price.Text = "label14";
            // 
            // h
            // 
            this.h.AllowItemSelection = true;
            this.h.Dock = System.Windows.Forms.DockStyle.Left;
            this.h.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.h.Location = new System.Drawing.Point(0, 36);
            this.h.Name = "h";
            this.h.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.h.Size = new System.Drawing.Size(260, 539);
            this.h.TabIndex = 1;
            this.h.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Company List";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1068, 36);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FluentDesignForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 575);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.h);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "FluentDesignForm1";
            this.NavigationControl = this.h;
            this.Text = "FluentDesignForm1";
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl h;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_opening_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_volume_1day;
        private System.Windows.Forms.Label label_volume_7day;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label_timestamp;
        private System.Windows.Forms.Label label_24H_fluctate_rate;
        private System.Windows.Forms.Label label_24H_fluctate;
        private System.Windows.Forms.Label label_sell_price;
        private System.Windows.Forms.Label label_buy_price;
        private System.Windows.Forms.Label label_units_traded;
        private System.Windows.Forms.Label label_average_price;
        private System.Windows.Forms.Label label_max_price;
        private System.Windows.Forms.Label label_min_price;
        private System.Windows.Forms.Label label_closing_price;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}