using System;

namespace COILibraryPoint
{
    /// <summary>
    /// interface that is the base of the role creator of the factory pattern
    /// </summary>
    /// <typeparam name="T">generic type used with constraints</typeparam>
    public interface PMCDataCreator<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        PMCDataModel<T> FactoryMethod();
    }

    /// <summary>
    /// on of the creators of the factory pattern
    /// </summary>
    /// <typeparam name="T">generic type used with constraints</typeparam>
    public class PositionCreator<T> : PMCDataCreator<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        public PMCDataModel<T> FactoryMethod() { return new PositionModel<T>(); }
    }

    /// <summary>
    /// on of the creators of the factory pattern
    /// </summary>
    /// <typeparam name="T">generic type used with constraints</typeparam>
    public class MatrixCreator<T> : PMCDataCreator<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        public PMCDataModel<T> FactoryMethod() { return new MatrixModel<T>(); }
    }

    /// <summary>
    /// on of the creators of the factory pattern
    /// </summary>
    /// <typeparam name="T">generic type used with constraints</typeparam>
    public class ContainerCreator<T> : PMCDataCreator<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        public PMCDataModel<T> FactoryMethod() { return new ContainerModel<T>(); }
    }

    /// <summary>
    /// on of the creators of the factory pattern
    /// </summary>
    /// <typeparam name="T">generic type used with constraints</typeparam>
    public class ContainersCreator<T> : PMCDataCreator<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        public PMCDataModel<T> FactoryMethod() { return new ContainersModel<T>(); }
    }
}
