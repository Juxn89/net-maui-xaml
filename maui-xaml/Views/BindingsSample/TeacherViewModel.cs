﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maui_xaml.Views.BindingsSample
{
    public class TeacherViewModel
    {
        private List<Teachers> teacherCollection = new List<Teachers>();
        public Command<string> MyCommand { set; get; }
        public string Message = string.Empty;

        public List<Teachers> TeacherCollection
        {
            get { return teacherCollection; }
            set { this.teacherCollection = value; }
        }

        public TeacherViewModel()
        {
            MyCommand = new Command<string>(ShowMessage);
            teacherCollection.Add(new Teachers("Leomaris", "Reyes", ".NET MAUI"));
            teacherCollection.Add(new Teachers("Ana Belisa", "Martinez", "Fundamentos de programación"));
            teacherCollection.Add(new Teachers("Nicolas", "Molina", "JavaScript"));
        }

        public async static void ShowMessage(string message)
        {
            await App.Navigation.PushAsync(new MainPage());
        }
    }
}
