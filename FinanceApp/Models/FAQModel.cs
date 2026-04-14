using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.Models
{
    public class FAQItem : BindableObject
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        private bool _isVisible;
        public bool IsVisible
        {
            get => _isVisible;
            set { _isVisible = value; OnPropertyChanged(); }
        }
    }
}
