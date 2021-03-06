﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF_08_ContactList.ViewModel.Command
{
    public class EditCommand : ICommand
    {
        public ContactVM VM { get; set; }
        public EditCommand() {}
        public EditCommand(ContactVM vm)
        {
            VM = vm;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            if (parameter is Button)
            {
                if (parameter != null)
                {
                    Button button = parameter as Button;
                    VM.Edit(button);
                }
            }
        }
    }
}
