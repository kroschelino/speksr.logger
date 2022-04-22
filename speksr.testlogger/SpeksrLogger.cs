using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
namespace Microsoft.VisualStudio.TestPlatform.Extensions.SpeksrLogger;


[FriendlyName(FriendlyName)]
[ExtensionUri(ExtensionUri)]
public class SpeksrLogger : ITestLogger
{
    /// <summary>
    /// Uri used to uniquely identify the logger.
    /// </summary>
    public const string ExtensionUri = "logger://Microsoft/TestPlatform/XUnitXmlLogger/v1";

    /// <summary>
    /// Alternate user friendly string to uniquely identify the console logger.
    /// </summary>
    public const string FriendlyName = "xunit";

    /// <summary>
    /// Initializes the Test Logger.
    /// </summary>
    /// <param name="events">Events that can be registered for.</param>
    /// <param name="testRunDirectory">Test Run Directory</param>
    public void Initialize(TestLoggerEvents events, string testRunDirectory)
    {

    }

}
