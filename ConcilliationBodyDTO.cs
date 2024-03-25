public class PostConcilliationBody
{
    public required List<BaseJson> DatabaseToFile { get; set; }
    public required List<BaseJson> FileToDatabase { get; set; }
    public required List<BaseJson> DifferentStatus { get; set; }
}
public class BaseJson
{
    public required int Id { get; set; }
    public required string Status { get; set; }
}