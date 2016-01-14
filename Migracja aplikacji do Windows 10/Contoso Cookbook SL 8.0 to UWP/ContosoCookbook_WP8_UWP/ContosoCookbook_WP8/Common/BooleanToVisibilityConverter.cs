// ----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// ----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
// ----------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
#if !WP7
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
#endif

namespace ContosoCookbook.Common
{

   /// <summary>
   /// Value converter that translates true to <see cref="Visibility.Visible"/> and false to
   /// <see cref="Visibility.Collapsed"/>.
   /// </summary>
   public sealed class BooleanToVisibilityConverter
      : Windows.UI.Xaml.Data.IValueConverter
   {

      public object Convert(object value, Type targetType, object parameter, System.String culture)
      {
         return (value is bool && (bool)value) ? Windows.UI.Xaml.Visibility.Visible : Windows.UI.Xaml.Visibility.Collapsed;
      }

      public object ConvertBack(object value, Type targetType, object parameter, System.String culture)
      {
         return value is Windows.UI.Xaml.Visibility && (Windows.UI.Xaml.Visibility)value == Windows.UI.Xaml.Visibility.Visible;
      }

   }

}