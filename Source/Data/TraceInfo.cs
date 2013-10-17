﻿using System;
using System.Diagnostics;

namespace LinqToDB.Data
{
	using System.Data;

	public class TraceInfo
	{
		public bool       BeforeExecute    { get; set; }
		public TraceLevel TraceLevel       { get; set; }
		public IDbCommand Command          { get; set; }
		public TimeSpan?  ExecutionTime    { get; set; }
		public int?       RecordsAaffected { get; set; }
		public Exception  Exception        { get; set; }
	}
}
