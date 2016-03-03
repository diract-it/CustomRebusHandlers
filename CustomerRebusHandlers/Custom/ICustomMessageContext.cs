namespace CustomerRebusHandlers.Custom
{
    /// <summary>
    /// The custom message context provides a custom API for contextual actions during message handling
    /// </summary>
    public interface ICustomMessageContext
    {
        void Reply(object reply);
    }
}