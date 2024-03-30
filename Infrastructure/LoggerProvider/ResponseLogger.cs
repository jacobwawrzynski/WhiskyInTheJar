using Infrastructure.DataContext;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.LoggerProvider
{
    public class ResponseLogger : ILogger
    {
        private readonly ApplicationDbContext _context;

        public ResponseLogger(ApplicationDbContext context)
        {
            _context = context;
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            throw new NotImplementedException();
        }
    }
}
