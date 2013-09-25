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

using System;
using Macro.Dicom.Iod.ContextGroups;
using Macro.Dicom.Iod.Macros;

namespace Macro.Dicom.Iod.Sequences
{
	/// <summary>
	/// BreedRegistry Code Sequence
	/// </summary>
	/// <remarks>As defined in the DICOM Standard 2008, Part 3, Section C.7.1.1 (Table C.7-1)</remarks>
	[Obsolete("Use ContextGroups.BreedRegistry instead.")]
	public class BreedRegistryCodeSequence : CodeSequenceMacro
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BreedRegistryCodeSequence"/> class.
		/// </summary>
		public BreedRegistryCodeSequence() : base()
		{
			base.ContextIdentifier = "7481";
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BreedRegistryCodeSequence"/> class.
		/// </summary>
		/// <param name="dicomSequenceItem">The dicom sequence item.</param>
		public BreedRegistryCodeSequence(DicomSequenceItem dicomSequenceItem) : base(dicomSequenceItem)
		{
			base.ContextIdentifier = "7481";
		}

		/// <summary>
		/// Converts a <see cref="BreedRegistryCodeSequence"/> to a <see cref="BreedRegistry"/>.
		/// </summary>
		/// <param name="code"></param>
		/// <returns></returns>
		public static implicit operator BreedRegistry(BreedRegistryCodeSequence code)
		{
			return new BreedRegistry(code.CodingSchemeDesignator, code.CodingSchemeVersion, code.CodeValue, code.CodeMeaning);
		}

		/// <summary>
		/// Converts a <see cref="BreedRegistry"/> to a <see cref="BreedRegistryCodeSequence"/>.
		/// </summary>
		/// <param name="breedRegistry"></param>
		/// <returns></returns>
		public static implicit operator BreedRegistryCodeSequence(BreedRegistry breedRegistry)
		{
			var codeSequence = new BreedRegistryCodeSequence();
			breedRegistry.WriteToCodeSequence(codeSequence);
			return codeSequence;
		}
	}
}