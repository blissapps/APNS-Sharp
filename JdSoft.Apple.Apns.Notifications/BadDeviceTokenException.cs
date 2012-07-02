using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JdSoft.Apple.Apns.Notifications
{
	public class BadDeviceTokenException : Exception
	{
		public BadDeviceTokenException(string deviceToken, object tag)
			: base(string.Format("Device Token Length ({0}) Is not the required length of {1} characters!", deviceToken.Length, Notification.DEVICE_TOKEN_STRING_SIZE))
		{
			this.DeviceToken = deviceToken;
			this.Tag = tag;
		}

		public string DeviceToken
		{
			get;
			private set;
		}

		public object Tag
		{
			get;
			private set;
		}
	}
}
