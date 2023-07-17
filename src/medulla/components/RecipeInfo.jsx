import React from 'react'

const RecipeInfo = ({ tc, prescription }) => {
  return (
		<div className='recipe-info'>
			<div className='info-primary'>
				<div className='info-table'>
					<div className='info-col'>
						<div className='info-cell'>
							<span>T.C. KimlikNo(*):</span>
							<input type='text' value={tc} />
						</div>
						<div className='info-cell'>
							<span>Medulla Takip No: </span>
							<input type='text' value='12451' />
						</div>
						<div className='info-cell'>
							<span>Reçete Tarihi(*): </span>
							<input type='date' value='2023-05-18' />
						</div>
						<div className='info-cell'>
							<span>Reçete Türü: </span>
							<select>
								<option value='normal'>normal</option>
							</select>
						</div>
					</div>
					<div className='info-col'>
						<div className='info-cell'>
							<span>Kapsam Türü:</span>
							<select>
								<option>4A Sigortalı (S.S.K.)</option>
							</select>
						</div>
						<div className='info-cell'>
							<span>Protokol No(*): </span>
							<input type='number' value='3653' />
						</div>
						<div className='info-cell'>
							<span>İlaç Alım Tarihi(*): </span>
							<input type='date' value='2023-05-18' />
						</div>
						<div className='info-cell'>
							<span>Reçete Alt Türü: </span>
							<select>
								<option value='normal'>normal</option>
							</select>
						</div>
					</div>
					<div className='info-col'>
						<div className='info-cell'>
							<span>Sigortalı Türü:</span>
							<select>
								<option>Çalışan</option>
							</select>
						</div>
						<div className='info-cell'>
							<span>Reç. No.:</span>
							<div className='tel'>
								<input type='text' value={prescription} className='w-100' />
							</div>
						</div>
						<div className='info-cell'>
							<span>Tesis Kodu(*): </span>
							<div className='flex'>
								<input type='text' value='19' />
								<button onClick={e => e.preventDefault()}>Ara</button>
								<button onClick={e => e.preventDefault()}>Bölümler</button>
							</div>
						</div>
						<div className='info-cell'>
							<span>Hasta Türü: </span>
							<select>
								<option value='normal'>normal</option>
							</select>
						</div>
					</div>
				</div>
			</div>
			<div className='info-secondary'>
				<div>
					Dr. Tescil No: <input type='number' value='791542' />
					<select>
						<option>hekim</option>
					</select>
					<button onClick={e => e.preventDefault()}>Ara</button>
					Dr. Diploma. No(*) : <input type='number' value='21642' />
					Dr. Adı/soyadı(*) : <input value='Ergun Murat' />{' '}
					<input value='Sulak' />
				</div>
				<div>
					Branş(*):
					<select className='major'>
						<option>İç Hastalıkları</option>
					</select>
					Sertifika(*):
					<select>
						<option>Yok</option>
					</select>
					<button onClick={e => e.preventDefault()}>Teşhisler</button>
					Karekodlu Reçete: <input type='checkbox' />
				</div>
			</div>
		</div>
	)
}

export default RecipeInfo
