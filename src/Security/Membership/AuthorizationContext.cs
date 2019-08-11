﻿/*
 *   _____                                ______
 *  /_   /  ____  ____  ____  _________  / __/ /_
 *    / /  / __ \/ __ \/ __ \/ ___/ __ \/ /_/ __/
 *   / /__/ /_/ / / / / /_/ /\_ \/ /_/ / __/ /_
 *  /____/\____/_/ /_/\__  /____/\____/_/  \__/
 *                   /____/
 *
 * Authors:
 *   钟峰(Popeye Zhong) <zongsoft@qq.com>
 *
 * Copyright (C) 2018-2019 Zongsoft Corporation <http://www.zongsoft.com>
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

namespace Zongsoft.Security.Membership
{
	public class AuthorizationContext
	{
		#region 构造函数
		public AuthorizationContext(uint userId, string schemaId, string actionId, bool isAuthorized)
		{
			this.UserId = userId;
			this.SchemaId = schemaId;
			this.ActionId = actionId;
			this.IsAuthorized = isAuthorized;
		}
		#endregion

		#region 公共属性
		/// <summary>
		/// 获取授权的用户编号。
		/// </summary>
		public uint UserId
		{
			get;
		}

		/// <summary>
		/// 获取待授权的资源标识。
		/// </summary>
		public string SchemaId
		{
			get;
		}

		/// <summary>
		/// 获取待授权的行为标识。
		/// </summary>
		public string ActionId
		{
			get;
		}

		/// <summary>
		/// 获取或设置是否授权通过。
		/// </summary>
		public bool IsAuthorized
		{
			get; set;
		}
		#endregion
	}
}