namespace BLForCalendar
{
    partial class FormForCalendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.myCalendarControl1 = new BLForCalendar.MyCalendarControl();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // myCalendarControl1
            // 
            this.myCalendarControl1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.myCalendarControl1.Location = new System.Drawing.Point(194, 18);
            this.myCalendarControl1.Name = "myCalendarControl1";
            this.myCalendarControl1.ShowWeekNumbers = false;
            this.myCalendarControl1.Size = new System.Drawing.Size(164, 162);
            this.myCalendarControl1.TabIndex = 1;
            this.myCalendarControl1.TitleBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.myCalendarControl1.TitleForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myCalendarControl1.TodayDate = new System.DateTime(2018, 1, 3, 0, 0, 0, 0);
            this.myCalendarControl1.TrailingForeColor = System.Drawing.SystemColors.GrayText;
            // 
            // FormForCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 261);
            this.Controls.Add(this.myCalendarControl1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "FormForCalendar";
            this.Text = "Календарь";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MyCalendarControl myCalendarControl1;
    }
}

