# guid-generator
A Cli to generate different types of Guid

Help:

    guid gtype  -- gtype --help

We can run cli with this instructions:

1) guid gtype --guid-type ulid (Generate a new Ulid identifier)
2) guid gtype --guid-type ulid --occurrences N (Substitute N with number of Ulid identifier occurrences)
3) guid gtype --guid-type guidv7 (Generate a new Guid according to RFC 9562, following the Version 7 format)
4) guid gtype --guid-type guidv7 --occurrences N (Substitute N with number of a new Guid according to RFC 9562, following the Version 7 format)
5) guid gtype --guid-type guid (Generate a new Guid)
6) guid gtype --guid-type guid --occurrences N (Substitute N with number of Guid to generate)