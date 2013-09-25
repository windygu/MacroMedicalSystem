#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.ClearCanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

using System.Collections.Generic;
using Macro.Common.Utilities;

namespace Macro.Common.Authorization
{
	/// <summary>
	/// Extension point for defining default authority groups to be imported at deployment time.
	/// </summary>
	[ExtensionPoint]
	public sealed class DefineAuthorityGroupsExtensionPoint : ExtensionPoint<IDefineAuthorityGroups>
	{
	}

	/// <summary>
	/// Helper class for setting up authority groups.
	/// </summary>
	public static class AuthorityGroupSetup
	{
		/// <summary>
		/// Returns the set of authority tokens defined by all plugins.
		/// </summary>
		/// <returns></returns>
		public static AuthorityTokenDefinition[] GetAuthorityTokens()
		{
			var tokens = new List<AuthorityTokenDefinition>();
			// scan all plugins for token definitions
			foreach (var plugin in Platform.PluginManager.Plugins)
			{
				var assembly = plugin.Assembly.Resolve();
				var resolver = new ResourceResolver(assembly);
				foreach (var type in plugin.Assembly.Resolve().GetTypes())
				{
					// look at public fields
					foreach (var field in type.GetFields())
					{
						var attr = AttributeUtils.GetAttribute<AuthorityTokenAttribute>(field, false);
						if (attr != null)
						{
							var token = (string)field.GetValue(null);
							var description = resolver.LocalizeString(attr.Description);
							var formerIdentities = (attr.Formerly ?? "").Split(';');

							tokens.Add(new AuthorityTokenDefinition(token, assembly.FullName, description, formerIdentities));
						}
					}
				}
			}
			return tokens.ToArray();
		}


		/// <summary>
		/// Returns the set of default authority groups defined by all plugins.
		/// </summary>
		/// <remarks>
		/// The default authority groups are only be used at deployment time to initialize the authorization system.
		/// They do not reflect the actual set of authority groups that exist for a given deployment.
		/// </remarks>
		/// <returns></returns>
		public static AuthorityGroupDefinition[] GetDefaultAuthorityGroups()
		{
			var groupDefs = new List<AuthorityGroupDefinition>();
			foreach (IDefineAuthorityGroups groupDefiner in new DefineAuthorityGroupsExtensionPoint().CreateExtensions())
			{
				var groups = groupDefiner.GetAuthorityGroups();
				if (groups != null)
				{
					groupDefs.AddRange(groups);
				}
			}
			return groupDefs.ToArray();
		}
	}
}
