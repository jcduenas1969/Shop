﻿namespace Shop.UIForms.Infrastructure
{
    using Shop.UIForms.ViewModels;

    public class InstanceLocator
    {

        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
