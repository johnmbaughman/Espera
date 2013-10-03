﻿using Akavache;
using Caliburn.Micro;
using Espera.Core.Settings;

namespace Espera.View.ViewModels
{
    internal class DesignTimeShellViewModel : ShellViewModel
    {
        public DesignTimeShellViewModel()
            : base(DesignTime.LoadLibrary(), new ViewSettings(BlobCache.InMemory), new CoreSettings(BlobCache.InMemory), new WindowManager())
        { }
    }
}