   M S B A M L   `   `   `  ����G  CTicketToolv2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:TicketToolv2.PropertiesTicketToolv2.Properties  5      e aMicrosoft.Web.WebView2.Wpf, Version=1.0.1072.54, Culture=neutral, PublicKeyToken=2a8ab48044d2601ekLclr-namespace:Microsoft.Web.WebView2.Wpf;assembly=Microsoft.Web.WebView2.WpfMicrosoft.Web.WebView2.Wpf 5	      !    TicketToolv2.Views.HTMLPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <
properties%clr-namespace:TicketToolv2.Properties     5      \wv2Lclr-namespace:Microsoft.Web.WebView2.Wpf;assembly=Microsoft.Web.WebView2.Wpf     5	         MahApps.Styles.Page#���   5        J� InputBindings  5      �� 5   
   
 �� Key$ F5��6    �� Command 6   �� *RefreshCommand+�� 5   
    �� 	Modifiers$	 Altf�6   $
 Left��6%    60   �� *BrowserBackCommand+�� 5   
   $	 Altf�6   $ Right��6%    61   �� *BrowserForwardCommand+�� 5   
   $
 Ctrlf�6   $ T��6&    6.   �� *OpenInBrowserCommand+.��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   )  #Microsoft.Web.WebView2.Wpf.WebView2  -   5          Name$ webView��5         Source 5      �� *Source+5      � 5   
   $��Bottom=�5      $��1��5        MahApps.Brushes.Gray10#���  5       � ColumnDefinitions 5      �� 5       $
��Auto �6#   �� 5!      $��* �6#   �� 5"      $
��Auto �6#   .+�5$      �� $��0��6    �� Orientation$ 
Horizontal=�6)   .+�5%      ��   WebViewButtonStyle#��[ 5'      '   !TicketToolv2.Properties.Resources 	   HTMLPageBackButtonTooltip
 � ToolTip#
 Z	 5(      ��5&      �� *BrowserBackCommand+.��5)      ��   SmallIconStyle#��[ 5*      $	����5+      5,      �� 5-      #��[ 5/      #   HTMLPageForwardButtonTooltip#
 Z 50      ��5.      �� *BrowserForwardCommand+.��51      �� #��[ 52      $	����53      54      55      �� 57      $��1��58      $��Center=�59        BodyTextStyle#��[ 5:        SmallLeftMargin#��[ 5;         HTMLPageLoadingText#��Z 5=      y�5<      �� *IsLoadingVisibility+5=      �� 5>      $��1��5?      $��Center=�5@      #��[ 5A      #��[ 5B         HTMLPageFaildedMessage#��Z 5D      y�5C      �� *FailedMesageVisibility+5D      �� 5E      $��2��6   $ 
Horizontal=�6)   .+�5F      �� #��[ 5H      #   HTMLPageRefreshButtonTooltip#
 Z 5I      4  .System.Windows.Automation.AutomationProperties   Name# Z 5J      ��5G      �� *RefreshCommand+.��5K      �� #��[ 5L      $	����5M      5N      �� 5O      #��[ 5Q      )   "HTMLPageOpenInBrowserButtonTooltip#
 Z 5R      # Z 5S      ��5P      �� *OpenInBrowserCommand+.��5T      �� #��[ 5U      $	����5V      5W      5X      5Y      5Z      5[      