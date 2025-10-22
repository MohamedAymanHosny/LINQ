## LINQ Methods Documentation

### 1. `First`

**Definition:** Returns the first element of a sequence.
**Exceptions:**

* `ArgumentNullException`: The source is null.
* `InvalidOperationException`: The source sequence is empty.

### 2. `FirstOrDefault`

**Definition:** Returns the first element of a sequence, or a default value if no element is found.
**Exceptions:**

* `ArgumentNullException`: The source is null.

### 3. `Last`

**Definition:** Returns the last element of a sequence.
**Exceptions:**

* `ArgumentNullException`: The source is null.
* `InvalidOperationException`: The source sequence is empty.

### 4. `LastOrDefault`

**Definition:** Returns the last element of a sequence, or a default value if no element is found.
**Exceptions:**

* `ArgumentNullException`: The source is null.

### 5. `Single`

**Definition:** Returns a single, specific element of a sequence.
**Exceptions:**

* `ArgumentNullException`: The source is null.
* `InvalidOperationException`: The input sequence contains more than one element, or the input sequence is empty.

### 6. `SingleOrDefault`

**Definition:** Returns a single, specific element of a sequence, or a default value if that element is not found.
**Exceptions:**

* `ArgumentNullException`: The source is null.
* `InvalidOperationException`: The input sequence contains more than one element.

### 7. `Any`

**Definition:** Determines whether any element of a sequence exists or satisfies a condition.
**Returns:** `Boolean` — `true` if the source sequence contains any elements; otherwise, `false`.
**Exceptions:**

* `ArgumentNullException`: The source is null.

### 8. `All`

**Definition:** Determines whether all elements of a sequence satisfy a condition.
**Returns:** `Boolean` — `true` if every element of the source sequence passes the test in the specified predicate, or if the sequence is empty; otherwise, `false`.
**Exceptions:**

* `ArgumentNullException`: The source or predicate is null.

### 9. `Distinct`

**Definition:** Returns distinct elements from a sequence.
**Parameters:**

* `source (IEnumerable<TSource>)`: The sequence to remove duplicate elements from.
* `comparer (IEqualityComparer<TSource>)`: An equality comparer to compare values.
  **Returns:** `IEnumerable<TSource>` — a sequence that contains the distinct elements.
  **Exceptions:**
* `ArgumentNullException`: The source is null.

### 10. `DistinctBy`

**Definition:** Returns distinct elements from a sequence according to a specified key selector function.
**Exceptions:**

* `ArgumentNullException`: The source is null.

### 11. `OrderBy`

**Definition:** Sorts the elements of a sequence in ascending order.
**Returns:** `IOrderedEnumerable<TSource>` — elements sorted according to a key.
**Exceptions:**

* `ArgumentNullException`: The source or keySelector is null.

### 12. `OrderByDescending`

**Definition:** Sorts the elements of a sequence in descending order.
**Parameters:**

* `source (IEnumerable<TSource>)`: Sequence to order.
* `keySelector (Func<TSource, TKey>)`: A key selector function.
* `comparer (IComparer<TKey>)`: A comparer to compare keys.
  **Returns:** `IOrderedEnumerable<TSource>` — elements sorted in descending order.
  **Exceptions:**
* `ArgumentNullException`: The source or keySelector is null.

### 13. `Count`

**Definition:** Returns the number of elements in a sequence.
**Returns:** `Int32` — the number of elements.
**Exceptions:**

* `ArgumentNullException`: The source is null.
* `OverflowException`: The number of elements exceeds `Int32.MaxValue`.

### 14. `CountBy`

**Definition:** Returns the count of elements in the source sequence grouped by a key.
**Returns:** `IEnumerable<KeyValuePair<TKey, Int32>>` — frequencies of key occurrences.
**Exceptions:**

* `ArgumentNullException`: The source is null.
