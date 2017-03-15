﻿/*
 * Authors:
 *   钟峰(Popeye Zhong) <zongsoft@gmail.com>
 *
 * Copyright (C) 2005-2008 Zongsoft Corporation <http://www.zongsoft.com>
 *
 * This file is part of Zongsoft.CoreLibrary.
 *
 * Zongsoft.CoreLibrary is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * Zongsoft.CoreLibrary is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * Lesser General Public License for more details.
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with Zongsoft.CoreLibrary; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zongsoft.Options
{
	internal static class OptionUtility
	{
		internal static bool ResolveOptionPath(string fullPath, out string path, out string name, out string member)
		{
			path = string.Empty;
			name = string.Empty;
			member = string.Empty;

			if(string.IsNullOrWhiteSpace(fullPath))
				return false;

			fullPath = fullPath.Trim().Trim('/').Trim();

			if(string.IsNullOrWhiteSpace(fullPath))
				return false;

			var parts = fullPath.Split('/');

			if(parts.Length > 1)
				path = string.Join("/", parts, 0, parts.Length - 1);
			else
				path = "/";

			name = parts[parts.Length - 1].Trim();
			var index = Math.Min(name.IndexOf('.'), name.IndexOf('['));

			if(index >= 0)
			{
				name = name.Substring(0, index);
				member = name.Substring(index + 1);
			}

			return true;
		}
	}
}
