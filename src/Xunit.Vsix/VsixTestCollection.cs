﻿using Xunit.Abstractions;
using Xunit.Sdk;

namespace Xunit
{
	class VsixTestCollection : TestCollection
	{
		public VsixTestCollection (ITestAssembly testAssembly, ITypeInfo collectionDefinition, 
			string visualStudioVersion, string rootSuffix)
			: base (testAssembly, collectionDefinition, visualStudioVersion + " (" + rootSuffix + ")")
		{
			VisualStudioVersion = visualStudioVersion;
			RootSuffix = rootSuffix;
		}

		public string VisualStudioVersion { get; private set; }

		public string RootSuffix { get; private set; }
	}
}
