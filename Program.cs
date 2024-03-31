using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using log4net.Util;
using ProjectCS.model;
using ProjectCS.repository;
using ProjectCS.repository.DBRepository;
using ProjectCS.repository.interfaces;
using ProjectCS.utils;
using ProjectCS.utils.factory;
using WindowsFormsApplication1;

namespace ProjectCS
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ContainerUtils containerUtils = Factory.GetContainer();
            SignInController mainWindowsForms = new SignInController(containerUtils);
            mainWindowsForms.ShowDialog();
        }

    }
}
