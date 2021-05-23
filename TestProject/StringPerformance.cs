using System;
using System.Text;
using Xunit;

namespace TestProject1
{
    public class StringPerformance
    {
        [Theory]
        [InlineData(1)]
        [InlineData(100)]
        [InlineData(100000)]
        public void Interpolation(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var sql = $@"Select
                    Name
                    Email
                    Address
                    From Customers
                    Where Id = {1}";
            }
        }

        [Theory]
        [InlineData(1)]
        [InlineData(100)]
        [InlineData(100000)]
        public void String(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var sql = $@"Select
                    Name
                    Email
                    Address
                    From Customers
                    Where Id = 1";
            }
        }

        [Theory]
        [InlineData(1)]
        [InlineData(100)]
        [InlineData(100000)]
        public void StringBuilder(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var sql = new StringBuilder();

                sql.AppendLine("Select");
                sql.AppendLine("Name");
                sql.AppendLine("Email");
                sql.AppendLine("Address");
                sql.AppendLine("From Customers");
                sql.AppendLine("Where Id = " + 1);
            }
        }

        [Theory]
        [InlineData(1)]
        [InlineData(100)]
        [InlineData(100000)]
        public void StringBuilderWithInterpolation(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var sql = new StringBuilder();

                sql.AppendLine("Select");
                sql.AppendLine("Name");
                sql.AppendLine("Email");
                sql.AppendLine("Address");
                sql.AppendLine("From Customers");
                sql.AppendLine($"Where Id = {1}");
            }
        }
    }
}
