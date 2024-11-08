﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace EuroBuld
{
	public class ServiceViewModel
	{
		public int ServiceID { get; set; }
		public string Item_Name { get; set; }
		public string Price { get; set; }

		// Property to get the image as an ImageSource
		public ImageSource ServiceImage
		{
			get
			{
				if (Image != null)
				{
					using (var ms = new MemoryStream(Image))
					{
						var bitmap = new BitmapImage();
						bitmap.BeginInit();
						bitmap.CacheOption = BitmapCacheOption.OnLoad;
						bitmap.StreamSource = ms;
						bitmap.EndInit();
						bitmap.Freeze();
						return bitmap;
					}
				}
				return null;
			}
		}

		public byte[] Image { get; set; }
	}
}
