﻿using Application.Repositories;
using Application.Repositories.BookRepository;
using Application.Repositories.CourseRepository;
using Application.Repositories.UserRepository;

namespace Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    public UnitOfWork(IReadBookRepository readBookRepository, IWriteBookRepository writeBookRepository, IReadUserRepository readUserRepository, IWriteUserRepository writeUserRepository, IReadCourseRepository readCourseRepository, IWriteCourseRepository writeCourseRepository)
    {
        ReadBookRepository = readBookRepository;
        WriteBookRepository = writeBookRepository;
        ReadUserRepository = readUserRepository;
        WriteUserRepository = writeUserRepository;
        ReadCourseRepository = readCourseRepository;
        WriteCourseRepository = writeCourseRepository;
    }

    public IReadBookRepository ReadBookRepository { get; }
    public IWriteBookRepository WriteBookRepository { get; }
    public IReadUserRepository ReadUserRepository  { get; }
    public IWriteUserRepository WriteUserRepository { get; }
    public IReadCourseRepository ReadCourseRepository { get;  }
    public IWriteCourseRepository WriteCourseRepository { get; }
}
