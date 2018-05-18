using System;
using System.Collections.Generic;

namespace COILibraryPoint
{
    public abstract class PMCDataModel<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        public List<dynamic> list = new List<dynamic>();
        public abstract void Add(params object[] parametres);

        /// <summary>
        /// Method returns list of the collection of the points etc
        /// </summary>
        /// <returns>list of points, matrixes etc</returns>
        public dynamic GetList()
        {
            try{
                return list;
            }

            catch (NullReferenceException){
                return null;
            }
        }

        /// <summary>
        /// indexator of the collection
        /// </summary>
        /// <param name="i">index of the collection</param>
        /// <returns>element of the collection</returns>
        public dynamic this[int i]
        {
            get
            {
                try{
                    return list[i];
                }
                catch (NullReferenceException){
                    return null;
                }
            }
            set
            {
                list[i] = value;
            }
        }
    }

    public class PositionModel<T> : PMCDataModel<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        /// <summary>
        /// overrided method to add an element to the collection
        /// </summary>
        /// <param name="array">collection of the boxed elements to add</param>
        public override void Add(object[] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            foreach (var i in array)
                    list.Add((Point<T>)i);
        }
    }

    public class MatrixModel<T> : PMCDataModel<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        /// <summary>
        /// overrided method to add an element to the collection
        /// </summary>
        /// <param name="array">collection of the boxed elements to add</param>
        public override void Add(object[] array)
        {
            try{
                foreach (var i in array)
                    list.Add((PositionModel<T>)i);
            }
            catch (InvalidCastException) { }
        }
    }

    public class ContainerModel<T> : PMCDataModel<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        /// <summary>
        /// overrided method to add an element to the collection
        /// </summary>
        /// <param name="array">collection of the boxed elements to add</param>
        public override void Add(object[] array){
            foreach (var i in array)
                list.Add((MatrixModel<T>)i);
        }
    }

    public class ContainersModel<T> : PMCDataModel<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        /// <summary>
        /// overrided method to add an element to the collection
        /// </summary>
        /// <param name="array">collection of the boxed elements to add</param>
        public override void Add(object[] array){
            foreach (var i in array)
                list.Add((ContainerModel<T>)i);
        }
    }
}
