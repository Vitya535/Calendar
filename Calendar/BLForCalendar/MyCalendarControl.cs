using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

//Практические задания
//При разработке любого элемента управления из списка ниже, кроме собственно разработки, необходимо с помощью атрибутов задать:
//●	описания свойств и событий;
//●	разделы в инспекторе свойств, в которых свойства и события помещаются;
//●	значения по умолчанию для свойств;
//●	свойство и событие по умолчанию;
//●	свойства, доступные для привязки;
//●	неотображаемые в инспекторе свойств свойства и события(если существует такая потребность);
//●	конвертеры и редакторы для свойств(если существует такая потребность).

//14.	Разработать элемент управления “Календарь” (специализированный, наследник от базового класса Control), 
//т.е.полностью новую реализацию данного элемента управления.

namespace BLForCalendar
{
    public partial class MyCalendarControl : UserControl
    {
        public MyCalendarControl()
        {
            InitializeComponent();
        }

        private Color trailingForeColor = Color.FromKnownColor(KnownColor.GrayText);
        private DateTime todayDate = DateTime.Today;
        private Color titleBackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        private Color titleForeColor = Color.FromKnownColor(KnownColor.ActiveCaptionText);
        private bool showWeekNumbers = false;

        [Bindable(true), Category("Appearance"), DefaultValue("GrayText")]
        public Color TrailingForeColor { get { return trailingForeColor; } set { trailingForeColor = value; } }

        [Bindable(true), Category("Appearance"), DefaultValue("Now")]
        public DateTime TodayDate { get { return todayDate; } set { todayDate = value; } }

        [Bindable(true), Category("Appearance"), DefaultValue("ActiveCaption")]
        public Color TitleBackColor { get { return titleBackColor; } set { titleBackColor = value; } }

        [Bindable(true), Category("Appearance"), DefaultValue("Now")]
        public Color TitleForeColor { get { return titleForeColor; } set { titleForeColor = value; } }

        [Bindable(true), Category("Appearance"), DefaultValue("false")]
        public bool ShowWeekNumbers { get { return showWeekNumbers; } set { showWeekNumbers = value; } }
    }
}
