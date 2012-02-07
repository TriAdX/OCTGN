﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Octgn.Controls
{
    /// <summary>
    ///   Interaction logic for NotificationListItem.xaml
    /// </summary>
    public partial class NotificationListItem : UserControl
    {
        public static DependencyProperty UsernameProperty = DependencyProperty.Register(
            "Message", typeof (string), typeof (FriendListItem));

        public static DependencyProperty PictureProperty = DependencyProperty.Register(
            "Picture", typeof (ImageSource), typeof (FriendListItem));

        public int NotificationNumber = -1;

        public NotificationListItem()
        {
            InitializeComponent();
        }

        public event MouseEventHandler OnClose;

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Focus();
        }

        private void imgDismiss_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (OnClose != null)
                OnClose.Invoke(this, new MouseEventArgs(e.MouseDevice, e.Timestamp));
        }
    }
}