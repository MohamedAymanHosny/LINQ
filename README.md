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
