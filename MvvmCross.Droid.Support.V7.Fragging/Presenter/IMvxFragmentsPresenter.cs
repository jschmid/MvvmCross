// IMvxFragmentsPresenter.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using Cirrious.MvvmCross.ViewModels;
using System.Collections.Generic;
using System;

namespace MvvmCross.Droid.Support.V7.Fragging.Presenter
{
    public interface IMvxFragmentsPresenter
    {
		void RegisterFragments (IEnumerable<Type> frags);
    }
}