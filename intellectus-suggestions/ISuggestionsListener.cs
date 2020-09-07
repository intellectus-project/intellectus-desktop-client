namespace Suggestions
{
    public interface ISuggestionsListener
    {
        void SuggestionAvailable(Suggestion suggestion);
    }
}