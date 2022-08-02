using System.Runtime.Serialization;

namespace FirstCSharp;
public class AnotherPerson : IFormatter
{
    public SerializationBinder? Binder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public StreamingContext Context { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public ISurrogateSelector? SurrogateSelector { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public object Deserialize(Stream serializationStream)
    {
        throw new NotImplementedException();
    }

    public void Serialize(Stream serializationStream, object graph)
    {
        throw new NotImplementedException();
    }
}