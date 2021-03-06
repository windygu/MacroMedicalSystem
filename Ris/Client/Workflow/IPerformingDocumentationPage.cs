#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
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

using System;
using ClearCanvas.Ris.Application.Common;

namespace ClearCanvas.Ris.Client.Workflow
{
    public class ProcedurePlanChangedEventArgs : EventArgs
    {
        private readonly ProcedurePlanDetail _procedurePlanDetail;

        public ProcedurePlanChangedEventArgs(ProcedurePlanDetail procedurePlanDetail)
        {
            _procedurePlanDetail = procedurePlanDetail;
        }

        public ProcedurePlanDetail ProcedurePlanDetail
        {
            get { return _procedurePlanDetail; }
        }
    }

    /// <summary>
    /// Defines an interface to a custom documentation page.
    /// </summary>
    public interface IPerformingDocumentationPage : IExtensionPage
    {
        bool Save(bool complete);
    }
}