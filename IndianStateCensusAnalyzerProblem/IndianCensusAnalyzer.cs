﻿using CsvHelper;
using IndianStateCensusAnalyzerTestPoblem;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyzerProblem
{
    public class IndianCencusAnalyzer
    {
        public int ReadStateCensusData(string filePath)
        {
            if (!File.Exists(filePath))
                throw new StateCencusException(StateCencusException.ExceptionType.FILE_INCORRECT, "Incorrect file path");
            if (!filePath.EndsWith(".csv"))
                throw new StateCencusException(StateCencusException.ExceptionType.TYPE_INCORRECT, "Type Incorrect");
            var read = File.ReadAllLines(filePath);
            string header = read[0];
            if (header.Contains("/"))
                throw new StateCencusException(StateCencusException.ExceptionType.DELIMETER, "Incorrect Delimeter");
            using (var reader = new StreamReader(filePath))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecords<StateCencusDAO>().ToList();
                foreach (var data in records)
                {
                    Console.WriteLine(data);
                }
                return records.Count() - 1;
            }
        }
        public bool ReadStateCencusData(string filePath, string actualHeader)
        {
            var read = File.ReadAllLines(filePath);
            string headern = read[0];
            if (headern.Equals(actualHeader))
                return true;
            else
                throw new StateCencusException(StateCencusException.ExceptionType.HEADER_INCORRECT, "Incorrect Header");
        }
    }
}