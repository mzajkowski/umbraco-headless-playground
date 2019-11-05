namespace Events.Demo.Client
{
    public interface IEventsHeadlessClient {
        object GetAllEvents();
        object GetEvent(string id);
    }

    public class EventsHeadlessClient : IEventsHeadlessClient
    {
        public object GetAllEvents()
        {
            throw new System.NotImplementedException();
        }

        public object GetEvent(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
