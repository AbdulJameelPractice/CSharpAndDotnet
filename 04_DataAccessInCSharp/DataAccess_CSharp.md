# Data Access in CSharp 

- store data in relational database and cache it locally in key value storage.
- `NoSQL` provides a complete different way of persisting data
  - key value store : persistent dictionary
  - graph database 
  - document database :Json data
- Connection string
  - IP Address / Resource File Name
  - Credentials: UserName & Password
- [Connection String Resource](https://www.connectionstrings.com/)
- Local DB
  - not for production
  - quickly get access to a database engine
  - No configuration necessary.
- SQLite
  - file based database
  - cross platform
  - Runs everywhere
  - Self contained
  - Lightweight

### Lazy Loading
- Load data only when it is needed
  - Lazy initialization
  - virtual proxies
  - Ghost objects
  - value holders
- When the value is null we try to load the data
- This requires the entity to know about accessing the service or database
- Lazy<T> provides support for lazy initialization implements the value holder and value loader patterns.
- Lazy<T> is thread safe
- 



## NO SQL
- A Relational database engine enforces relationships between tables
- Relational data is not verified by the NoSQL database engine
- often fast and scalable.
- Data in NoSQL is accessed through keys
- `document database`
  - JSON, XML or other supported formats
  - invoice data, customer data, product data
  - mongoDB, CosmosDB, amazon DynamoDB
  - all the data in one place, useful to store entities with all its related data in one place
  - document is accessible with a partition key, a good partitioning leads to better scaling. use to determine in which partition to store the data, a good
  partition key makes scaling easier and better.
  - Row Key: The key for the row in the specified partition, used to index the data in the partition, has to be unique
  - data: the data serialized in a format like JSON
- `Key Value store`
  - dictionary, json binary simple or complex types
  - Good for caching, its used like a hosted scalable dictionary to cache data.
  - Redis is a common key value store
  - distributed cache to store data that is frequently accessed
  - redis is an in memory cache, if the instance or server restart all data is lost.
- `Table Store`
  - Tabular data, looks like any column from a traditional database without the relationships
  - Good for lots of data, not uncommon to be used for terabytes of data
  - can have a lot of data in one table
  - schema less
  - 
  