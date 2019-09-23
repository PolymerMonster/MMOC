﻿using BackgroundManagement.Interfaces;
using BackgroundManagement.Models.Commands;

namespace BackgroundManagement.DataHandlers.CommandBuilding
{
    public class GetAccountCharsCmdBuilder : ICommandBuilder
    {
        private static readonly string _keyWord = "getaccountchars";

        private CommandDetails _commandDetails = new CommandDetails();

        public void AddKeyword()
        {
            _commandDetails.CommandElementList.Add(_keyWord);
        }

        public void AddCommandElements()
        {
            //do nothing
        }
        
        public string GetCommand()
        {
            return _commandDetails.GetFullCommand();
        }
    }
}
