CC = gcc
CFLAGS = -I "./include"
LDFLAGS = -o
SRCDIR = ./src
LIBDIR = ./lib
BINDIR = ./bin
SOURCES = $(wildcard $(SRCDIR)/*.c)
OBJECTS = $(patsubst $(SRCDIR)/%.c,$(LIBDIR)/%.o,$(SOURCES))

program: $(OBJECTS)
	$(CC) $(OBJECTS) $(LDFLAGS) $(BINDIR)/program

$(LIBDIR)/%.o: $(SRCDIR)/%.c
	$(CC) $(CFLAGS) -c $< -o $@

calistir:
	./$(BINDIR)/program

clean:
	rm -f $(LIBDIR)/*.o $(BINDIR)/program
