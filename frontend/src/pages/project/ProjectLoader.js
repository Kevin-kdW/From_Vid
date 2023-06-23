 
export const ProjectLoader = async ({params}) => {
    const projectId = params.projectId;

    return {
        id: projectId,
        title: `Project ${projectId}`,
        description: `Another description for ${projectId}`,
        todos:[
            {
                id: 1,
                title: 'Todo 1',
                description: 'FIrst todo',
                status: 3, 
            },
            {
                id: 2,
                title: 'Todo 2',
                description: 'FIrst todo',
                status: 1, 
            },
            {
                id: 3,
                title: 'Todo 3',
                description: 'FIrst todo',
                status: 2, 
            },
        ]
    }
}
