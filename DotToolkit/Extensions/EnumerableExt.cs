using System.Collections.Generic;

namespace DotToolkit.Extensions;

public static class EnumerableExt
{
    //public static TCollection Map<TCollection, TValue, TResult>(this TCollection source, Func<TValue, int, TResult> selector) where TCollection : ICollection<TValue>, new()
    //{
    //    if (source is null) throw new ArgumentNullException(nameof(source));
    //    if (selector is null) throw new ArgumentNullException(nameof(selector));
    //    var result = new TCollection();
    //    foreach (var item in source)
    //        result.Add(item);
    //    return result;
    //}
    //public static TCollection Map<TCollection, TValue, TResult>(this TCollection source, Func<TValue, TResult> selector) where TCollection : ICollection<TValue>
    //{
    //    if (source is null) throw new ArgumentNullException(nameof(source));
    //    if (selector is null) throw new ArgumentNullException(nameof(selector));
    //    var result = (TCollection)Activator.CreateInstance(typeof(TCollection));
    //    //var result = new TCollection();
    //    foreach (TValue item in source)
    //        result.Add((TValue)(object)selector(item));
    //    return result;
    //}

    //public static IEnumerable<TResult> Select<TSource, TResult>(
    //    this IEnumerable<TSource> source,
    //    Func<TSource, TResult> selector)
    //{
    //    // Validar los parámetros
    //    if (source == null)
    //        throw new ArgumentNullException(nameof(source));
    //    if (selector == null)
    //        throw new ArgumentNullException(nameof(selector));

    //    // Iterar sobre cada elemento de la colección original
    //    foreach (TSource item in source)
    //    {
    //        // Aplicar la función de transformación y devolver el resultado
    //        yield return selector(item);
    //    }
    //}

    //public static IEnumerable<TResult> Map<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
    //{

    //}
    //public static IEnumerable<TResult> Map<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
    //{

    //}
}
