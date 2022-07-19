cmake_minimum_required(VERSION 3.20)
project(InteropExamples VERSION 0.1)
set(CMAKE_CXX_STANDARD 17)

set(LIBRARY_NAME "DummyLib")

set(SRC
    "src/ExampleFunctions.cpp"
 )

# library public interface
set(INC
    "include/ExampleFunctions.h"
)

# the library is build as shared library
add_library(${LIBRARY_NAME} SHARED ${SRC} ${HEADERS} ${INC})

target_include_directories(${LIBRARY_NAME} PUBLIC "include")
message(${CMAKE_CURRENT_LIST_DIR}/../../managed/DummyLib.Wrapper/native/)

add_custom_command(
    TARGET ${LIBRARY_NAME}
    POST_BUILD
    COMMAND ${CMAKE_COMMAND} -E copy ${CMAKE_BINARY_DIR}/DummyLib.dll ${CMAKE_CURRENT_LIST_DIR}/../../managed/DummyLib.Wrapper/native/
    COMMAND ${CMAKE_COMMAND} -E copy ${CMAKE_BINARY_DIR}/DummyLib.pdb ${CMAKE_CURRENT_LIST_DIR}/../../managed/DummyLib.Wrapper/native/
    COMMENT "copy artifacts"
)