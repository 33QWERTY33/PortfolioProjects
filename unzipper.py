
import os
import zipfile
import sys

def remove_file(directory):
    os.remove(directory)

def extract_zip_files(directory):
    for root, dirs, files in os.walk(directory):
        for file in files:
            print(file)
            if file.endswith('.zip'):
                file_path = os.path.join(root, file)
                extract_folder = os.path.splitext(file_path)[0]  # Remove .zip extension
                with zipfile.ZipFile(file_path, 'r') as zip_ref:
                    zip_ref.extractall(extract_folder)
                if len(sys.argv) == 2:
                    if sys.argv[1] == "--remove":
                        remove_file(file)
                print(f"Extracted {file} to {extract_folder}")
                


# Call the function to extract .zip files
if len(sys.argv) == 2 and sys.argv[1] == "-h":
    print("optional --remove flag\nsupply target directory to search for .zip files")
elif len(sys.argv) == 3:
    extract_zip_files(sys.argv[2])
elif len(sys.argv) == 2:
    extract_zip_files(sys.argv[1])
else:
    extract_zip_files(os.getcwd())
