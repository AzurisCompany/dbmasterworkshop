﻿using System;
using System.Collections.Generic;
using System.Text;

namespace dbmasteraapp.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Settings,
        PesquisaHelpDesk,
        CriarChamado
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }
    }
}
