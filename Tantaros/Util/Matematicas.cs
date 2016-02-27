//
//  Matematicas.cs
//
//  Author:
//       stalin <stalin.mora.burgos@gmail.com>
//
//  Copyright (c) 2016 stalin
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;

namespace Tantaros.Util
{
	public class Matematicas
	{
		public Matematicas ()
		{
		}

		public static long factorial(int num)
		{
			if (num == 0)
			{
				return 1;
			}
			else
			{
				return num * factorial (num - 1);
			}
		}

		public void saludar()
		{
			Console.WriteLine ("Hola Mundo.\n");
		}
	}
}

