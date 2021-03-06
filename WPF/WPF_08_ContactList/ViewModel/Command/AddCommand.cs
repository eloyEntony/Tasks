﻿using System;
using System.Windows.Input;
using WPF_08_ContactList.Model;

namespace WPF_08_ContactList.ViewModel.Command
{
    public class AddCommand : ICommand
    {
        ContactVM VM { get; set; }
        public AddCommand(ContactVM vm)
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
            Contact contact = (parameter as Contact);
            if (contact != null)
                if (contact.Name != null && contact.Surname != null && contact.Number != null)
                {
                    try
                    {
                        int tmpNumber = System.Convert.ToInt32(contact.Number);
                        for (int i = 0; i < VM.Contacts.Count; i++)
                        {
                            if (VM.Contacts[i].Number == tmpNumber.ToString())
                                return false;
                        }
                        return true;
                    }
                    catch
                    {
                        return false;
                    }

                }
            return false;
        }

        public void Execute(object parameter)
        {
            VM.AddToList();
        }
    }


}
