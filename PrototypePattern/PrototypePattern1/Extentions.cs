using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrototypePattern1
{
    public static class Extentions
    {
        public static T DeepCopy<T>(this T self)
        {
            if (!typeof(T).IsSerializable)
                throw new ArgumentException("Тип должен быть сериализован");

            if (ReferenceEquals(self, null))
                return default(T);

            var formatter = new BinaryFormatter();

            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, self);
                stream.Seek(0, SeekOrigin.Begin);

                return (T)formatter.Deserialize(stream);
            }
        }

        public static T DeepCopyWithDefault<T>(this T self)
        {
            if (!typeof(T).IsSerializable)
                throw new ArgumentException("Тип должен быть сериализован");

            if (ReferenceEquals(self, null))
                return default(T);

            var formatter = new BinaryFormatter();

            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, self);
                stream.Seek(0, SeekOrigin.Begin);

                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
